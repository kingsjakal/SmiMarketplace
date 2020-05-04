using Smi.Core.Domain.Catalog;
using Smi.Services.Caching;

namespace Smi.Services.Catalog.Caching
{
    /// <summary>
    /// Represents a product review helpfulness cache event consumer
    /// </summary>
    public partial class ProductReviewHelpfulnessCacheEventConsumer : CacheEventConsumer<ProductReviewHelpfulness>
    {
    }
}
