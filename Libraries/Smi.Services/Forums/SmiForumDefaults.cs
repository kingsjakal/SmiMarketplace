using Smi.Core.Caching;

namespace Smi.Services.Forums
{
    /// <summary>
    /// Represents default values related to forums services
    /// </summary>
    public static partial class SmiForumDefaults
    {
        #region Caching defaults

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        public static CacheKey ForumGroupAllCacheKey => new CacheKey("Smi.forumgroup.all");

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : forum group ID
        /// </remarks>
        public static CacheKey ForumAllByForumGroupIdCacheKey => new CacheKey("Smi.forum.allbyforumgroupid-{0}");

        #endregion
    }
}