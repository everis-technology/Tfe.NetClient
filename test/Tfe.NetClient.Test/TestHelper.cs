namespace Tfe.NetClient.Test
{
    public class TestHelper
    {
        public static TfeClient GetTestClient(string testFile)
        {
            var httpClient = new TestHttpClient()
            {
                Handler = (entry) =>
                {
                    TestHttpClient.SendResponse(testFile, entry);
                }
            };

            var config = new TfeConfig("faketoken", httpClient);

            return new TfeClient(config);
        }
    }
}
