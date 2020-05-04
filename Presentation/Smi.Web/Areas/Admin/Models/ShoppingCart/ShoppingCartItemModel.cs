using System;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.ShoppingCart
{
    /// <summary>
    /// Represents a shopping cart item model
    /// </summary>
    public partial class ShoppingCartItemModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.CurrentCarts.Store")]
        public string Store { get; set; }

        [SmiResourceDisplayName("Admin.CurrentCarts.Product")]
        public int ProductId { get; set; }

        [SmiResourceDisplayName("Admin.CurrentCarts.Product")]
        public string ProductName { get; set; }

        public string AttributeInfo { get; set; }

        [SmiResourceDisplayName("Admin.CurrentCarts.UnitPrice")]
        public string UnitPrice { get; set; }

        [SmiResourceDisplayName("Admin.CurrentCarts.Quantity")]
        public int Quantity { get; set; }

        [SmiResourceDisplayName("Admin.CurrentCarts.Total")]
        public string Total { get; set; }

        [SmiResourceDisplayName("Admin.CurrentCarts.UpdatedOn")]
        public DateTime UpdatedOn { get; set; }

        #endregion
    }
}