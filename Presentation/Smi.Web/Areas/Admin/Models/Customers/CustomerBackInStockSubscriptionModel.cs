using System;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer back in stock subscription model
    /// </summary>
    public partial class CustomerBackInStockSubscriptionModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Customers.Customers.BackInStockSubscriptions.Store")]
        public string StoreName { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.BackInStockSubscriptions.Product")]
        public int ProductId { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.BackInStockSubscriptions.Product")]
        public string ProductName { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.BackInStockSubscriptions.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        #endregion
    }
}