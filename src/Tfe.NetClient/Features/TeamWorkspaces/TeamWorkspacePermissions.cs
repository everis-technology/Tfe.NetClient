namespace Tfe.NetClient.TeamWorkspaces
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// AccessPermissions
    /// </summary>
    /// <value></value>
    public static class AccessPermissions
    {
        public const string Read = "read";
        public const string Plan = "plan";
        public const string Write = "write";
        public const string Admin = "admin";
        public const string Custom = "custom";
    }

    /// <summary>
    /// RunPermissions
    /// </summary>
    /// <value></value>
    public static class RunPermissions
    {
        public const string Read = "read";
        public const string Plan = "plan";
        public const string Apply = "apply";

    }

    /// <summary>
    /// VariablesPermissions
    /// </summary>
    /// <value></value>
    public static class VariablesPermissions
    {
        public const string None = "none";
        public const string Read = "read";
        public const string Write = "write";
    }

    /// <summary>
    /// StateVersionsPermissions
    /// </summary>
    /// <value></value>
    public static class StateVersionsPermissions
    {
        public const string None = "none";
        public const string ReadOutputs = "read-outputs";
        public const string Read = "read";
        public const string Write = "write";
    }

    /// <summary>
    /// SentinelMocksPermissions
    /// </summary>
    /// <value></value>
    public static class SentinelMocksPermissions
    {
        public const string None = "none";
        public const string Read = "read";
    }

    /// <summary>
    /// TeamWorkspacePermissions
    /// </summary>
    /// <value></value>
    public class TeamWorkspacePermissions
    {
        /// <summary>
        /// TeamWorkspacePermissions
        /// </summary>
        /// <value></value>
        public TeamWorkspacePermissions()
        {
        }

        /// <summary>
        /// Access
        /// </summary>
        /// <value></value>
        [JsonPropertyName("access")]
        public string Access { get; set; }


        private string _runs;
        private string _variables;
        private string _stateVersions;
        private string _sentinelMocks;

#nullable enable
        /// <summary>
        /// Runs
        /// </summary>
        /// <value></value>
        [JsonPropertyName("runs")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Runs { get => GetSuitablePermission(_runs); set => _runs = value; }

        /// <summary>
        /// Variables
        /// </summary>
        /// <value></value>
        [JsonPropertyName("variables")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Variables { get => GetSuitablePermission(_variables); set => _variables = value; }

        /// <summary>
        /// StateVersions
        /// </summary>
        /// <value></value>
        [JsonPropertyName("state-versions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string StateVersions { get => GetSuitablePermission(_stateVersions); set => _stateVersions = value; }

        /// <summary>
        /// SentinelMocks
        /// </summary>
        /// <value></value>
        [JsonPropertyName("sentinel-mocks")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string SentinelMocks { get => GetSuitablePermission(_sentinelMocks); set => _sentinelMocks = value; }
#nullable disable

        /// <summary>
        /// WorkspaceLocking
        /// </summary>
        /// <value></value>
        [JsonPropertyName("workspace-locking")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool WorkspaceLocking { get; set; }

        private string GetSuitablePermission(string propertyValue)
        {
            if (Access == AccessPermissions.Custom)
            {
                return propertyValue;
            }
            else
            {
                return null;
            }
        }
    }
}


