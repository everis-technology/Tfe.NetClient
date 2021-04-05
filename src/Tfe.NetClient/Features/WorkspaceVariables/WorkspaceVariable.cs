namespace Tfe.NetClient.WorkspaceVariables
{
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// WorkspaceVariable
    /// </summary>
    public class WorkspaceVariable : BaseClient
    {

        /// <summary>
        /// WorkspaceVariable
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public WorkspaceVariable(HttpClient client) : base(client)
        {
        }

        /// <summary>
        /// CreateAsync
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<WorkspaceVariableResponse> CreateAsync(string workspaceId, WorkspaceVariablesRequest request)
        {
            return await PostAsync<WorkspaceVariablesRequest, WorkspaceVariableResponse>($"workspaces/{workspaceId}/vars", request).ConfigureAwait(false);
        }
    }
}