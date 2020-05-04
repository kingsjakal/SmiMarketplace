using Smi.Core.Domain.Localization;
using Smi.Services.Caching;

namespace Smi.Services.Localization.Caching
{
    /// <summary>
    /// Represents a language cache event consumer
    /// </summary>
    public partial class LanguageCacheEventConsumer : CacheEventConsumer<Language>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(Language entity)
        {
            Remove(_cacheKeyService.PrepareKey(SmiLocalizationDefaults.LocaleStringResourcesAllPublicCacheKey, entity));
            Remove(_cacheKeyService.PrepareKey(SmiLocalizationDefaults.LocaleStringResourcesAllAdminCacheKey, entity));
            Remove(_cacheKeyService.PrepareKey(SmiLocalizationDefaults.LocaleStringResourcesAllCacheKey, entity));

            var prefix = _cacheKeyService.PrepareKeyPrefix(SmiLocalizationDefaults.LocaleStringResourcesByResourceNamePrefixCacheKey, entity);
            RemoveByPrefix(prefix);

            RemoveByPrefix(SmiLocalizationDefaults.LanguagesAllPrefixCacheKey);
        }
    }
}