using System;
using Microsoft.AspNetCore.Mvc;
using Smi.Services.Customers;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class ProfileInfoViewComponent : SmiViewComponent
    {
        private readonly ICustomerService _customerService;
        private readonly IProfileModelFactory _profileModelFactory;

        public ProfileInfoViewComponent(ICustomerService customerService, IProfileModelFactory profileModelFactory)
        {
            _customerService = customerService;
            _profileModelFactory = profileModelFactory;
        }

        public IViewComponentResult Invoke(int customerProfileId)
        {
            var customer = _customerService.GetCustomerById(customerProfileId);
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            var model = _profileModelFactory.PrepareProfileInfoModel(customer);
            return View(model);
        }
    }
}
