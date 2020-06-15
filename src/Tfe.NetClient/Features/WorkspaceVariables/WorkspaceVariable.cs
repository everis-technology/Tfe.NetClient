namespace Tfe.NetClient.WorkspaceVariables
{
    using System.Net.Http;
    using System.Threading.Tasks;

    public class WorkspaceVariable : BaseClient
    {

        public WorkspaceVariable(HttpClient client) : base(client)
        {
        }

        public async Task<WorkspaceVariableResponse> CreateAsync(string workspaceId, WorkspaceVariablesRequest request)
        {
            return await PostAsync<WorkspaceVariablesRequest, WorkspaceVariableResponse>($"workspaces/{workspaceId}/vars", request).ConfigureAwait(false);
        }
    }
}