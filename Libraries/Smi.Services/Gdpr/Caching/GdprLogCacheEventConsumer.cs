using Smi.Core.Domain.Gdpr;
using Smi.Services.Caching;

namespace Smi.Services.Gdpr.Caching
{
    /// <summary>
    /// Represents a GDPR log cache event consumer
    /// </summary>
    public partial class GdprLogCacheEventConsumer : CacheEventConsumer<GdprLog>
    {
    }
}
