using System;
using System.ComponentModel.DataAnnotations;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Affiliates
{
    /// <summary>
    /// Represents an affiliate search model
    /// </summary>
    public partial class AffiliateSearchModel : BaseSearchModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Affiliates.List.SearchFirstName")]
        public string SearchFirstName { get; set; }

        [SmiResourceDisplayName("Admin.Affiliates.List.SearchLastName")]
        public string SearchLastName { get; set; }

        [SmiResourceDisplayName("Admin.Affiliates.List.SearchFriendlyUrlName")]
        public string SearchFriendlyUrlName { get; set; }

        [SmiResourceDisplayName("Admin.Affiliates.List.LoadOnlyWithOrders")]
        public bool LoadOnlyWithOrders { get; set; }

        [SmiResourceDisplayName("Admin.Affiliates.List.OrdersCreatedFromUtc")]
        [UIHint("DateNullable")]
        public DateTime? OrdersCreatedFromUtc { get; set; }

        [SmiResourceDisplayName("Admin.Affiliates.List.OrdersCreatedToUtc")]
        [UIHint("DateNullable")]
        public DateTime? OrdersCreatedToUtc { get; set; }

        #endregion
    }
}