using Microsoft.AspNetCore.Mvc;
using Smi.Core;
using Smi.Plugin.Payments.CheckMoneyOrder.Models;
using Smi.Services.Localization;
using Smi.Web.Framework.Components;

namespace Smi.Plugin.Payments.CheckMoneyOrder.Components
{
    [ViewComponent(Name = "CheckMoneyOrder")]
    public class CheckMoneyOrderViewComponent : SmiViewComponent
    {
        private readonly CheckMoneyOrderPaymentSettings _checkMoneyOrderPaymentSettings;
        private readonly ILocalizationService _localizationService;
        private readonly IStoreContext _storeContext;
        private readonly IWorkContext _workContext;

        public CheckMoneyOrderViewComponent(CheckMoneyOrderPaymentSettings checkMoneyOrderPaymentSettings,
            ILocalizationService localizationService,
            IStoreContext storeContext,
            IWorkContext workContext)
        {
            _checkMoneyOrderPaymentSettings = checkMoneyOrderPaymentSettings;
            _localizationService = localizationService;
            _storeContext = storeContext;
            _workContext = workContext;
        }

        public IViewComponentResult Invoke()
        {
            var model = new PaymentInfoModel
            {
                DescriptionText = _localizationService.GetLocalizedSetting(_checkMoneyOrderPaymentSettings,
                    x => x.DescriptionText, _workContext.WorkingLanguage.Id, _storeContext.CurrentStore.Id)
            };

            return View("~/Plugins/Payments.CheckMoneyOrder/Views/PaymentInfo.cshtml", model);
        }
    }
}