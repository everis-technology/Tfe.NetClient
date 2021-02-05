using System;
using System.Text.Json.Serialization;

namespace Tfe.NetClient.TeamWorkspaces
{
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
    }

    /// <summary>
    /// TeamWorkspaceCustomPermissions
    /// </summary>
    /// <value></value>
    public class TeamWorkspaceCustomPermissions : TeamWorkspacePermissions
    {
        /// <summary>
        /// TeamWorkspaceCustomPermissions
        /// </summary>
        /// <value></value>
        public TeamWorkspaceCustomPermissions()
        {
            Access = AccessPermissions.Custom;
        }

        /// <summary>
        /// Runs
        /// </summary>
        /// <value></value>
        [JsonPropertyName("runs")]
        public string Runs { get; set; }

        /// <summary>
        /// Variables
        /// </summary>
        /// <value></value>
        [JsonPropertyName("variables")]
        public string Variables { get; set; }

        /// <summary>
        /// StateVersions
        /// </summary>
        /// <value></value>
        [JsonPropertyName("state-versions")]
        public string StateVersions { get; set; }

        /// <summary>
        /// SentinelMocks
        /// </summary>
        /// <value></value>
        [JsonPropertyName("sentinel-mocks")]
        public string SentinelMocks { get; set; }

        /// <summary>
        /// WorkspaceLocking
        /// </summary>
        /// <value></value>
        [JsonPropertyName("workspace-locking")]
        public bool WorkspaceLocking { get; set; }
    }
}
