using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a return request search model
    /// </summary>
    public class ReturnRequestSearchModel: BaseSearchModel
    {
        #region Ctor

        public ReturnRequestSearchModel()
        {
            ReturnRequestStatusList = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.ReturnRequests.SearchStartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [SmiResourceDisplayName("Admin.ReturnRequests.SearchEndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }

        [SmiResourceDisplayName("Admin.ReturnRequests.SearchCustomNumber")]
        public string CustomNumber { get; set; }

        [SmiResourceDisplayName("Admin.ReturnRequests.SearchReturnRequestStatus")]
        public int ReturnRequestStatusId { get; set; }

        public IList<SelectListItem> ReturnRequestStatusList { get; set; }

        #endregion
    }
}