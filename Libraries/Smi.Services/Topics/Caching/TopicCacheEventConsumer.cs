using Smi.Core.Domain.Topics;
using Smi.Services.Caching;

namespace Smi.Services.Topics.Caching
{
    /// <summary>
    /// Represents a topic cache event consumer
    /// </summary>
    public partial class TopicCacheEventConsumer : CacheEventConsumer<Topic>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(Topic entity)
        {
            RemoveByPrefix(SmiTopicDefaults.TopicsAllPrefixCacheKey);
            var prefix = _cacheKeyService.PrepareKeyPrefix(SmiTopicDefaults.TopicBySystemNamePrefixCacheKey, entity.SystemName);
            RemoveByPrefix(prefix);
        }
    }
}
