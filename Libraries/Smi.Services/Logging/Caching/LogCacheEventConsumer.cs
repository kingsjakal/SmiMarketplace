using Smi.Core.Domain.Logging;
using Smi.Services.Caching;

namespace Smi.Services.Logging.Caching
{
    /// <summary>
    /// Represents a log cache event consumer
    /// </summary>
    public partial class LogCacheEventConsumer : CacheEventConsumer<Log>
    {
    }
}
