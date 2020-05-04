using Smi.Core.Domain.Common;
using Smi.Services.Caching;

namespace Smi.Services.Common.Caching
{
    /// <summary>
    /// Represents a search term cache event consumer
    /// </summary>
    public partial class SearchTermCacheEventConsumer : CacheEventConsumer<SearchTerm>
    {
    }
}
