﻿namespace Hircine.Core
{
    /// <summary>
    /// Command object used to represent an index creation job requested by the client
    /// </summary>
    public class IndexBuildCommand
    {
        /// <summary>
        /// Tells the IndexJobManager to execute the result against an embedded database only (thus, ignoring any connection strings)
        /// </summary>
        public bool UseEmbedded { get; set; }

        /// <summary>
        /// Tells the IndexJobManager to only execute against one database at a time
        /// </summary>
        public bool ExecuteJobsSequentially { get; set; }

        /// <summary>
        /// If a single index build result comes back negative, the job will stop will stop if we're running sequentially.
        /// 
        /// This flag will override that behavior and continue building even if there are failures
        /// </summary>
        public bool ContinueJobOnFailure { get; set; }

        /// <summary>
        /// The set of all connection strings for each server we want to build against"
        /// </summary>
        public string[] ConnectionStrings { get; set; }

        /// <summary>
        /// The paths to each index-containing assembly we want to build against for each server
        /// </summary>
        public string[] AssemblyPaths { get; set; }

        /// <summary>
        /// Raven normally throws an exception if you try to connect to a database using username / password authentication
        /// without SSL. This field will suppress that error when set to true.
        /// </summary>
        public bool UseUserNamePasswordWithoutSSL { get; set; }

        /// <summary>
        /// Pause Raven's indexing system while we wait
        /// </summary>
        public bool PauseIndexing { get; set; }

        /// <summary>
        /// Remove any versioned index definitions that do not match the active index as
        /// defined in the loaded assemblies.
        /// </summary>
        public bool DropInactiveVersionedIndexes { get; set; }
    }
}
