﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Discounts
{
    /// <summary>
    /// Represents a discount requirement rule model
    /// </summary>
    public partial class DiscountRequirementRuleModel : BaseSmiModel
    {
        #region Ctor

        public DiscountRequirementRuleModel()
        {
            ChildRequirements = new List<DiscountRequirementRuleModel>();
        }

        #endregion

        #region Properties

        public int DiscountRequirementId { get; set; }

        public string RuleName { get; set; }

        public string ConfigurationUrl { get; set; }

        public int InteractionTypeId { get; set; }

        public int? ParentId { get; set; }

        public SelectList AvailableInteractionTypes { get; set; }

        public bool IsGroup { get; set; }

        public bool IsLastInGroup { get; set; }

        public IList<DiscountRequirementRuleModel> ChildRequirements { get; set; }

        #endregion
    }
}