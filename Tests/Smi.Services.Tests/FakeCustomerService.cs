using Moq;
using Smi.Core;
using Smi.Core.Caching;
using Smi.Core.Domain.Common;
using Smi.Core.Domain.Customers;
using Smi.Core.Domain.Orders;
using Smi.Data;
using Smi.Services.Caching;
using Smi.Services.Common;
using Smi.Services.Customers;
using Smi.Services.Events;
using Smi.Tests;

namespace Smi.Services.Tests
{
    public class FakeCustomerService : CustomerService
    {
        public FakeCustomerService(CachingSettings cachingSettings = null,
            CustomerSettings customerSettings = null,
            ICacheKeyService cacheKeyService = null,
            IEventPublisher eventPublisher = null,
            IGenericAttributeService genericAttributeService = null,
            IRepository<Address> customerAddressRepository = null,
            IRepository<Customer> customerRepository = null,
            IRepository<CustomerAddressMapping> customerAddressMappingRepository = null,
            IRepository<CustomerCustomerRoleMapping> customerCustomerRoleMappingRepository = null,
            IRepository<CustomerPassword> customerPasswordRepository = null,
            IRepository<CustomerRole> customerRoleRepository = null,
            IRepository<GenericAttribute> gaRepository = null,
            IRepository<ShoppingCartItem> shoppingCartRepository = null,
            IStoreContext storeContext = null,
            ShoppingCartSettings shoppingCartSettings = null) : base(
            cachingSettings ?? new CachingSettings(),
            customerSettings ?? new CustomerSettings(),
            cacheKeyService ?? new FakeCacheKeyService(),
            eventPublisher ?? new Mock<IEventPublisher>().Object,
            genericAttributeService ?? new Mock<IGenericAttributeService>().Object,
            customerAddressRepository.FakeRepoNullPropagation(),
            customerRepository.FakeRepoNullPropagation(),
            customerAddressMappingRepository.FakeRepoNullPropagation(),
            customerCustomerRoleMappingRepository.FakeRepoNullPropagation(),
            customerPasswordRepository.FakeRepoNullPropagation(),
            customerRoleRepository.FakeRepoNullPropagation(),
            gaRepository.FakeRepoNullPropagation(),
            shoppingCartRepository.FakeRepoNullPropagation(),
            new TestCacheManager(),
            storeContext ?? new Mock<IStoreContext>().Object,
            shoppingCartSettings ?? new ShoppingCartSettings())
        {
        }
    }
}
