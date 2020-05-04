using Smi.Core.Caching;

namespace Smi.Services.Gdpr
{
    /// <summary>
    /// Represents default values related to Gdpr services
    /// </summary>
    public static partial class SmiGdprDefaults
    {
        #region Caching defaults

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        public static CacheKey ConsentsAllCacheKey => new CacheKey("Smi.consents.all");

        #endregion
    }
}