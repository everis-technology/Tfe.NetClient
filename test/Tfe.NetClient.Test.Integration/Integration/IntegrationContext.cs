namespace Tfe.NetClient
{
    /// <summary>
    /// IntegrationContext
    /// </summary>
    public static class IntegrationContext
    {
        /// <summary>
        /// OAuthTokenId
        /// </summary>
        /// <value></value>
        public static string OAuthTokenId { get; set; }
        
        /// <summary>
        /// WorkspaceId
        /// </summary>
        /// <value></value>
        public static string WorkspaceId { get; set; }

        /// <summary>
        /// RunId
        /// </summary>
        /// <value></value>
        public static string RunId { get; set; }

        /// <summary>
        /// SshKeyId
        /// </summary>
        /// <value></value>
        public static string SshKeyId { get; set; }
    }
}