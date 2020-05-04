using Smi.Core.Domain.Vendors;
using Smi.Services.Caching;

namespace Smi.Services.Vendors.Caching
{
    /// <summary>
    /// Represents a vendor note cache event consumer
    /// </summary>
    public partial class VendorNoteCacheEventConsumer : CacheEventConsumer<VendorNote>
    {
    }
}
