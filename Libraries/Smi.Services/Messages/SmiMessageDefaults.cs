using Smi.Core.Caching;

namespace Smi.Services.Messages
{
    /// <summary>
    /// Represents default values related to messages services
    /// </summary>
    public static partial class SmiMessageDefaults
    {
        /// <summary>
        /// Gets a key for notifications list from TempDataDictionary
        /// </summary>
        public static string NotificationListKey => "NotificationList";

        #region Caching defaults

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : store ID
        /// </remarks>
        public static CacheKey MessageTemplatesAllCacheKey => new CacheKey("Smi.messagetemplate.all-{0}", MessageTemplatesAllPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string MessageTemplatesAllPrefixCacheKey => "Smi.messagetemplate.all";

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : template name
        /// {1} : store ID
        /// </remarks>
        public static CacheKey MessageTemplatesByNameCacheKey => new CacheKey("Smi.messagetemplate.name-{0}-{1}", MessageTemplatesByNamePrefixCacheKey);

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : template name
        /// </remarks>
        public static string MessageTemplatesByNamePrefixCacheKey => "Smi.messagetemplate.name-{0}";

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : store ID
        /// </remarks>
        public static CacheKey EmailAccountsAllCacheKey => new CacheKey("Smi.emailaccounts.all");

        #endregion
    }
}