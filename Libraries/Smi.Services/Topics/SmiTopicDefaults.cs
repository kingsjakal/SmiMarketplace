using Smi.Core.Caching;

namespace Smi.Services.Topics
{
    /// <summary>
    /// Represents default values related to topic services
    /// </summary>
    public static partial class SmiTopicDefaults
    {
        #region Caching defaults

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : store ID
        /// {1} : show hidden?
        /// {2} : include in top menu?
        /// </remarks>
        public static CacheKey TopicsAllCacheKey => new CacheKey("Smi.topics.all-{0}-{1}-{2}", TopicsAllPrefixCacheKey);

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : store ID
        /// {1} : show hidden?
        /// {2} : include in top menu?
        /// {3} : customer role IDs hash
        /// </remarks>
        public static CacheKey TopicsAllWithACLCacheKey => new CacheKey("Smi.topics.all.acl-{0}-{1}-{2}-{3}", TopicsAllPrefixCacheKey);

        /// <summary>
        /// Gets a pattern to clear cache
        /// </summary>
        public static string TopicsAllPrefixCacheKey => "Smi.topics.all";

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : topic system name
        /// {1} : store id
        /// {2} : customer roles Ids hash
        /// </remarks>
        public static CacheKey TopicBySystemNameCacheKey => new CacheKey("Smi.topics.systemName-{0}-{1}-{2}", TopicBySystemNamePrefixCacheKey);

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : topic system name
        /// </remarks>
        public static string TopicBySystemNamePrefixCacheKey => "Smi.topics.systemName-{0}";

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        public static CacheKey TopicTemplatesAllCacheKey => new CacheKey("Smi.topictemplates.all");

        #endregion
    }
}