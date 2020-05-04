using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Messages
{
    /// <summary>
    /// Represents a newsletter subscription search model
    /// </summary>
    public partial class NewsletterSubscriptionSearchModel : BaseSearchModel
    {
        #region Ctor

        public NewsletterSubscriptionSearchModel()
        {
            AvailableStores = new List<SelectListItem>();
            ActiveList = new List<SelectListItem>();
            AvailableCustomerRoles = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        [DataType(DataType.EmailAddress)]
        [SmiResourceDisplayName("Admin.Promotions.NewsLetterSubscriptions.List.SearchEmail")]
        public string SearchEmail { get; set; }

        [SmiResourceDisplayName("Admin.Promotions.NewsLetterSubscriptions.List.SearchStore")]
        public int StoreId { get; set; }

        public IList<SelectListItem> AvailableStores { get; set; }

        [SmiResourceDisplayName("Admin.Promotions.NewsLetterSubscriptions.List.SearchActive")]
        public int ActiveId { get; set; }

        [SmiResourceDisplayName("Admin.Promotions.NewsLetterSubscriptions.List.SearchActive")]
        public IList<SelectListItem> ActiveList { get; set; }

        [SmiResourceDisplayName("Admin.Promotions.NewsLetterSubscriptions.List.CustomerRoles")]
        public int CustomerRoleId { get; set; }

        public IList<SelectListItem> AvailableCustomerRoles { get; set; }

        [SmiResourceDisplayName("Admin.Promotions.NewsLetterSubscriptions.List.StartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [SmiResourceDisplayName("Admin.Promotions.NewsLetterSubscriptions.List.EndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }

        public bool HideStoresList { get; set; }

        #endregion
    }
}