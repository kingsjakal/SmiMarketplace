using Smi.Core.Caching;

namespace Smi.Services.Logging
{
    /// <summary>
    /// Represents default values related to logging services
    /// </summary>
    public static partial class SmiLoggingDefaults
    {
        #region Caching defaults

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        public static CacheKey ActivityTypeAllCacheKey => new CacheKey("Smi.activitytype.all");

        #endregion
    }
}