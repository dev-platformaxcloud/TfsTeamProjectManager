﻿
namespace TeamProjectManager.Common
{
    /// <summary>
    /// Provides information about a Team Foundation Server.
    /// </summary>
    public sealed class TeamFoundationServerInfo
    {
        /// <summary>
        /// Gets the major version of the Team Foundation Server.
        /// </summary>
        public TfsMajorVersion MajorVersion { get; private set; }

        /// <summary>
        /// Gets the display version of the Team Foundation Server.
        /// </summary>
        public string DisplayVersion { get; private set; }

        /// <summary>
        /// Gets the short display version of the Team Foundation Server.
        /// </summary>
        public string ShortDisplayVersion { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamFoundationServerInfo"/> class.
        /// </summary>
        /// <param name="majorVersion">The major version of the Team Foundation Server.</param>
        public TeamFoundationServerInfo(TfsMajorVersion majorVersion)
        {
            this.MajorVersion = majorVersion;
            switch (this.MajorVersion)
            {
                case TfsMajorVersion.Tfs2005:
                    this.DisplayVersion = "Team Foundation Server 2005";
                    this.ShortDisplayVersion = "TFS 2005";
                    break;
                case TfsMajorVersion.Tfs2008:
                    this.DisplayVersion = "Team Foundation Server 2008";
                    this.ShortDisplayVersion = "TFS 2008";
                    break;
                case TfsMajorVersion.Tfs2010:
                    this.DisplayVersion = "Team Foundation Server 2010";
                    this.ShortDisplayVersion = "TFS 2010";
                    break;
                default:
                    this.DisplayVersion = "Unknown version of Team Foundation Server";
                    this.ShortDisplayVersion = "Unknown TFS Version";
                    break;
            }
        }
    }
}