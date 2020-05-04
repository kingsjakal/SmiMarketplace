using Smi.Core.Domain.Configuration;
using Smi.Services.Caching;

namespace Smi.Services.Configuration.Caching
{
    /// <summary>
    /// Represents a setting cache event consumer
    /// </summary>
    public partial class SettingCacheEventConsumer : CacheEventConsumer<Setting>
    {
    }
}