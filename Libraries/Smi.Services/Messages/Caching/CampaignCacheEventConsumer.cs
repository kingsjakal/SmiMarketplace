using Smi.Core.Domain.Messages;
using Smi.Services.Caching;

namespace Smi.Services.Messages.Caching
{
    /// <summary>
    /// Represents a campaign cache event consumer
    /// </summary>
    public partial class CampaignCacheEventConsumer : CacheEventConsumer<Campaign>
    {
    }
}
