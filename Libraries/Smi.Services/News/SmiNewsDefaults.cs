using Smi.Core.Caching;

namespace Smi.Services.News
{
    /// <summary>
    /// Represents default values related to orders services
    /// </summary>
    public static partial class SmiNewsDefaults
    {
        #region Caching defaults

        /// <summary>
        /// Key for number of news comments
        /// </summary>
        /// <remarks>
        /// {0} : news item ID
        /// {1} : store ID
        /// {2} : are only approved comments?
        /// </remarks>
        public static CacheKey NewsCommentsNumberCacheKey => new CacheKey("Smi.news.comments.number-{0}-{1}-{2}", NewsCommentsNumberPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        /// <remarks>
        /// {0} : news item ID
        /// </remarks>
        public static string NewsCommentsNumberPrefixCacheKey => "Smi.news.comments.number-{0}";

        #endregion
    }
}