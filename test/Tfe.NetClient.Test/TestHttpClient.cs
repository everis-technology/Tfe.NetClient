// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
// ------------------------------------------------------------
// Original file: https://github.com/dapr/dotnet-sdk/blob/master/test/Shared/TestHttpClient.cs

namespace Tfe.NetClient
{
    using System;
    using System.Collections.Concurrent;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Reflection;
    using System.Text.Json;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Extensions.FileProviders;

    // This client will capture all requests, and put them in .Requests for you to inspect.
    public class TestHttpClient : HttpClient
    {
        static EmbeddedFileProvider embeddedProvider = new EmbeddedFileProvider(Assembly.GetExecutingAssembly());

        private readonly TestHttpClientHandler handler;

        public TestHttpClient()
            : this(new TestHttpClientHandler())
        {
        }

        private TestHttpClient(TestHttpClientHandler handler)
            : base(handler)
        {
            this.handler = handler;
        }

        public ConcurrentQueue<Entry> Requests => this.handler.Requests;

        public Action<Entry> Handler
        {
            get => this.handler.Handler;
            set => this.handler.Handler = value;
        }

        public class Entry
        {
            public Entry(HttpRequestMessage request)
            {
                this.Request = request;

                this.Completion = new TaskCompletionSource<HttpResponseMessage>(TaskCreationOptions.RunContinuationsAsynchronously);
            }

            public TaskCompletionSource<HttpResponseMessage> Completion { get; }

            public HttpRequestMessage Request { get; }

            public void Respond(HttpResponseMessage response)
            {
                this.Completion.SetResult(response);
            }

            public void RespondWithResponse(HttpResponseMessage response)
            {
                this.Completion.SetResult(response);
            }

            public void RespondWithJson<TValue>(TValue value, JsonSerializerOptions options = null)
            {
                var bytes = JsonSerializer.SerializeToUtf8Bytes(value, options);

                var response = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new ByteArrayContent(bytes)
                };
                response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json") { CharSet = "UTF-8", };

                this.Completion.SetResult(response);
            }

            public void Throw(Exception exception)
            {
                this.Completion.SetException(exception);
            }
        }

        private class TestHttpClientHandler : HttpMessageHandler
        {
            public TestHttpClientHandler()
            {
                this.Requests = new ConcurrentQueue<Entry>();
            }

            public ConcurrentQueue<Entry> Requests { get; }

            public Action<Entry> Handler { get; set; }

            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                var entry = new Entry(request);
                this.Handler?.Invoke(entry);
                this.Requests.Enqueue(entry);

                using (cancellationToken.Register(() => entry.Completion.TrySetCanceled()))
                {
                    return await entry.Completion.Task.ConfigureAwait(false);
                }
            }
        }

        static public void SendResponse(string responseFile, TestHttpClient.Entry entry)
        {
            var file = $"ResponseSamples/{responseFile}.json";
            using (var stream = embeddedProvider.GetFileInfo(file).CreateReadStream())
            {
                using (var reader = new StreamReader(stream))
                {
                    var body = reader.ReadToEnd();

                    var response = new HttpResponseMessage
                    {
                        StatusCode = System.Net.HttpStatusCode.OK,
                        Content = new StringContent(
                               body, System.Text.Encoding.UTF8,
                               "application/json"),
                    };

                    entry.Completion.SetResult(response);
                }
            }
        }
    }
}