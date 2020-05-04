using Smi.Core.Domain.Gdpr;
using Smi.Services.Caching;

namespace Smi.Services.Gdpr.Caching
{
    /// <summary>
    /// Represents a GDPR consent cache event consumer
    /// </summary>
    public partial class GdprConsentCacheEventConsumer : CacheEventConsumer<GdprConsent>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(GdprConsent entity)
        {
            Remove(SmiGdprDefaults.ConsentsAllCacheKey);
        }
    }
}