using Microsoft.AspNetCore.Mvc;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class PrivateMessagesInboxViewComponent : SmiViewComponent
    {
        private readonly IPrivateMessagesModelFactory _privateMessagesModelFactory;

        public PrivateMessagesInboxViewComponent(IPrivateMessagesModelFactory privateMessagesModelFactory)
        {
            _privateMessagesModelFactory = privateMessagesModelFactory;
        }

        public IViewComponentResult Invoke(int pageNumber, string tab)
        {
            var model = _privateMessagesModelFactory.PrepareInboxModel(pageNumber, tab);
            return View(model);
        }
    }
}
