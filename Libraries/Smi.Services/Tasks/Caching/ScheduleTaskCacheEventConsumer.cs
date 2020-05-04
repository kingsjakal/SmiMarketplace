using Smi.Core.Domain.Tasks;
using Smi.Services.Caching;

namespace Smi.Services.Tasks.Caching
{
    /// <summary>
    /// Represents a schedule task cache event consumer
    /// </summary>
    public partial class ScheduleTaskCacheEventConsumer : CacheEventConsumer<ScheduleTask>
    {
    }
}
