using System;
using System.Collections.Generic;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;
using Smi.Web.Models.Common;

namespace Smi.Web.Models.Order
{
    public partial class CustomerRewardPointsModel : BaseSmiModel
    {
        public CustomerRewardPointsModel()
        {
            RewardPoints = new List<RewardPointsHistoryModel>();
        }

        public IList<RewardPointsHistoryModel> RewardPoints { get; set; }
        public PagerModel PagerModel { get; set; }
        public int RewardPointsBalance { get; set; }
        public string RewardPointsAmount { get; set; }
        public int MinimumRewardPointsBalance { get; set; }
        public string MinimumRewardPointsAmount { get; set; }

        #region Nested classes

        public partial class RewardPointsHistoryModel : BaseSmiEntityModel
        {
            [SmiResourceDisplayName("RewardPoints.Fields.Points")]
            public int Points { get; set; }

            [SmiResourceDisplayName("RewardPoints.Fields.PointsBalance")]
            public string PointsBalance { get; set; }

            [SmiResourceDisplayName("RewardPoints.Fields.Message")]
            public string Message { get; set; }

            [SmiResourceDisplayName("RewardPoints.Fields.CreatedDate")]
            public DateTime CreatedOn { get; set; }

            [SmiResourceDisplayName("RewardPoints.Fields.EndDate")]
            public DateTime? EndDate { get; set; }
        }

        #endregion
    }
}