using Moq;
using Smi.Core;
using Smi.Core.Domain.Common;
using Smi.Core.Domain.Customers;
using Smi.Core.Domain.Shipping;
using Smi.Core.Domain.Tax;
using Smi.Services.Common;
using Smi.Services.Customers;
using Smi.Services.Directory;
using Smi.Services.Events;
using Smi.Services.Logging;
using Smi.Services.Tax;
using Smi.Tests;

namespace Smi.Services.Tests.FakeServices
{
    public class FakeTaxService : TaxService
    {
        public FakeTaxService(AddressSettings addressSettings = null,
            CustomerSettings customerSettings = null,
            IAddressService addressService = null,
            ICountryService countryService = null,
            ICustomerService customerService = null,
            IEventPublisher eventPublisher = null,
            IGenericAttributeService genericAttributeService = null,
            IGeoLookupService geoLookupService = null,
            ILogger logger = null,
            IStateProvinceService stateProvinceService = null,
            IStoreContext storeContext = null,
            ITaxPluginManager taxPluginManager = null,
            IWebHelper webHelper = null,
            IWorkContext workContext = null,
            ShippingSettings shippingSettings = null,
            TaxSettings taxSettings = null) : base(
                addressSettings ?? new AddressSettings(),
                customerSettings ?? new CustomerSettings(),
                addressService ?? new Mock<IAddressService>().Object,
                countryService ?? new Mock<ICountryService>().Object,
                customerService ?? new Mock<ICustomerService>().Object,
                eventPublisher ?? new Mock<IEventPublisher>().Object,
                genericAttributeService ?? new Mock<IGenericAttributeService>().Object,
                geoLookupService ?? new Mock<IGeoLookupService>().Object,
                logger ?? new NullLogger(),
                stateProvinceService ?? new Mock<IStateProvinceService>().Object,
                storeContext ?? new Mock<IStoreContext>().Object,
                taxPluginManager ?? new Mock<ITaxPluginManager>().Object,
                webHelper ?? new Mock<IWebHelper>().Object,
                workContext ?? new Mock<IWorkContext>().Object,
                shippingSettings ?? new ShippingSettings(),
                taxSettings ?? new TaxSettings())
        {
        }
    }
}
