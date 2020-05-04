using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a reward points model to add to the customer
    /// </summary>
    public partial class AddRewardPointsToCustomerModel : BaseSmiModel
    {
        #region Ctor

        public AddRewardPointsToCustomerModel()
        {
            AvailableStores = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        public int CustomerId { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.RewardPoints.Fields.Points")]
        public int Points { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.RewardPoints.Fields.Message")]
        public string Message { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.RewardPoints.Fields.Store")]
        public int StoreId { get; set; }

        public IList<SelectListItem> AvailableStores { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.RewardPoints.Fields.ActivatePointsImmediately")]
        public bool ActivatePointsImmediately { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.RewardPoints.Fields.ActivationDelay")]
        public int ActivationDelay { get; set; }

        public int ActivationDelayPeriodId { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.RewardPoints.Fields.PointsValidity")]
        [UIHint("Int32Nullable")]
        public int? PointsValidity { get; set; }

        #endregion
    }
}