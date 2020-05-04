using Smi.Core.Caching;

namespace Smi.Services.Blogs
{
    /// <summary>
    /// Represents default values related to blogs services
    /// </summary>
    public static partial class SmiBlogsDefaults
    {
        #region Caching defaults

        /// <summary>
        /// Key for number of blog comments
        /// </summary>
        /// <remarks>
        /// {0} : blog post ID
        /// {1} : store ID
        /// {2} : are only approved comments?
        /// </remarks>
        public static CacheKey BlogCommentsNumberCacheKey => new CacheKey("Smi.blog.comments.number-{0}-{1}-{2}", BlogCommentsNumberPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        /// <remarks>
        /// {0} : blog post ID
        /// </remarks>
        public static string BlogCommentsNumberPrefixCacheKey => "Smi.blog.comments.number-{0}";

        /// <summary>
        /// Key for blog tag list model
        /// </summary>
        /// <remarks>
        /// {0} : language ID
        /// {1} : current store ID
        /// {2} : show hidden?
        /// </remarks>
        public static CacheKey BlogTagsModelCacheKey => new CacheKey("Smi.blog.tags-{0}-{1}-{2}", BlogTagsPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string BlogTagsPrefixCacheKey => "Smi.blog.tags";

        #endregion
    }
}