using Microsoft.AspNetCore.Mvc;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class SelectedCheckoutAttributesViewComponent : SmiViewComponent
    {
        private readonly IShoppingCartModelFactory _shoppingCartModelFactory;

        public SelectedCheckoutAttributesViewComponent(IShoppingCartModelFactory shoppingCartModelFactory)
        {
            _shoppingCartModelFactory = shoppingCartModelFactory;
        }

        public IViewComponentResult Invoke()
        {
            var attributes = _shoppingCartModelFactory.FormatSelectedCheckoutAttributes();
            return View(null, attributes);
        }
    }
}
