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

        /// <summary>
        /// GetWorkspaceVariableAsync
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <returns></returns>
        public async Task<WorkspaceVariablesResponse> GetWorkspaceVariableAsync(string workspaceId)
        {
            return await GetAsync<WorkspaceVariablesResponse>($"workspaces/{workspaceId}/vars").ConfigureAwait(false);
        }

        /// <summary>
        /// UpdateWorkspaceVariable
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <returns></returns>
        public async Task<WorkspaceVariablesResponse> UpdateWorkspaceVariable(string workspaceId, string variableId, WorkspaceVariablesRequest request)
        {
            return await PatchAsync<WorkspaceVariablesRequest, WorkspaceVariablesResponse>($"workspaces/{workspaceId}/vars/{variableId}", request).ConfigureAwait(false);
        }
    }
}