using Smi.Core.Domain.Shipping;
using Smi.Services.Caching;

namespace Smi.Services.Shipping.Caching
{
    /// <summary>
    /// Represents a shipping method-country mapping cache event consumer
    /// </summary>
    public partial class ShippingMethodCountryMappingCacheEventConsumer : CacheEventConsumer<ShippingMethodCountryMapping>
    {
    }
}