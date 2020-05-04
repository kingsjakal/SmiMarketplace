using Smi.Core.Domain.Logging;
using Smi.Services.Caching;

namespace Smi.Services.Logging.Caching
{
    /// <summary>
    /// Represents an activity log cache event consumer
    /// </summary>
    public partial class ActivityLogCacheEventConsumer : CacheEventConsumer<ActivityLog>
    {
    }
}