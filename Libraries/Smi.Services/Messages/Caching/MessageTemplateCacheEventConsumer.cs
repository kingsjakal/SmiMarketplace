using Smi.Core.Domain.Messages;
using Smi.Services.Caching;

namespace Smi.Services.Messages.Caching
{
    /// <summary>
    /// Represents a message template cache event consumer
    /// </summary>
    public partial class MessageTemplateCacheEventConsumer : CacheEventConsumer<MessageTemplate>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(MessageTemplate entity)
        {
            RemoveByPrefix(SmiMessageDefaults.MessageTemplatesAllPrefixCacheKey);
            var prefix = _cacheKeyService.PrepareKeyPrefix(SmiMessageDefaults.MessageTemplatesByNamePrefixCacheKey, entity.Name);
            RemoveByPrefix(prefix);
        }
    }
}
