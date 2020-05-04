using System.Collections.Generic;
using Smi.Web.Framework.Models;
using Smi.Web.Models.Common;

namespace Smi.Web.Models.Catalog
{
    public partial class CustomerBackInStockSubscriptionsModel : BaseSmiModel
    {
        public CustomerBackInStockSubscriptionsModel()
        {
            Subscriptions = new List<BackInStockSubscriptionModel>();
        }

        public IList<BackInStockSubscriptionModel> Subscriptions { get; set; }
        public PagerModel PagerModel { get; set; }

        #region Nested classes

        public partial class BackInStockSubscriptionModel : BaseSmiEntityModel
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public string SeName { get; set; }
        }

        #endregion
    }
}