using Microsoft.AspNetCore.Mvc;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class PrivateMessagesSentItemsViewComponent : SmiViewComponent
    {
        private readonly IPrivateMessagesModelFactory _privateMessagesModelFactory;

        public PrivateMessagesSentItemsViewComponent(IPrivateMessagesModelFactory privateMessagesModelFactory)
        {
            _privateMessagesModelFactory = privateMessagesModelFactory;
        }

        public IViewComponentResult Invoke(int pageNumber, string tab)
        {
            var model = _privateMessagesModelFactory.PrepareSentModel(pageNumber, tab);
            return View(model);
        }
    }
}
