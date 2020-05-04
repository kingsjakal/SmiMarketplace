using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.News
{
    /// <summary>
    /// Represents a news comment search model
    /// </summary>
    public partial class NewsCommentSearchModel : BaseSearchModel
    {
        #region Ctor

        public NewsCommentSearchModel()
        {
            AvailableApprovedOptions = new List<SelectListItem>();
        }

        #endregion

        #region Properties
        
        public int? NewsItemId { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.News.Comments.List.CreatedOnFrom")]
        [UIHint("DateNullable")]
        public DateTime? CreatedOnFrom { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.News.Comments.List.CreatedOnTo")]
        [UIHint("DateNullable")]
        public DateTime? CreatedOnTo { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.News.Comments.List.SearchText")]
        public string SearchText { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.News.Comments.List.SearchApproved")]
        public int SearchApprovedId { get; set; }

        public IList<SelectListItem> AvailableApprovedOptions { get; set; }

        #endregion
    }
}