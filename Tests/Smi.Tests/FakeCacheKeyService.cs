using Smi.Core.Caching;
using Smi.Services.Caching;

namespace Smi.Tests
{
    public class FakeCacheKeyService : CacheKeyService
    {
        public FakeCacheKeyService() : base(new CachingSettings())
        {
        }
    }
}
