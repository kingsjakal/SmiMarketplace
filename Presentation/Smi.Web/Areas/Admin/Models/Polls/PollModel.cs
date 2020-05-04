using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Polls
{
    /// <summary>
    /// Represents a poll model
    /// </summary>
    public partial class PollModel : BaseSmiEntityModel, IStoreMappingSupportedModel
    {
        #region Ctor

        public PollModel()
        {
            AvailableLanguages = new List<SelectListItem>();
            AvailableStores = new List<SelectListItem>();
            SelectedStoreIds = new List<int>();
            PollAnswerSearchModel = new PollAnswerSearchModel();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.ContentManagement.Polls.Fields.Language")]
        public int LanguageId { get; set; }

        public IList<SelectListItem> AvailableLanguages { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Polls.Fields.Language")]
        public string LanguageName { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Polls.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Polls.Fields.SystemKeyword")]
        public string SystemKeyword { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Polls.Fields.Published")]
        public bool Published { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Polls.Fields.ShowOnHomepage")]
        public bool ShowOnHomepage { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Polls.Fields.AllowGuestsToVote")]
        public bool AllowGuestsToVote { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Polls.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Polls.Fields.StartDate")]
        [UIHint("DateTimeNullable")]
        public DateTime? StartDateUtc { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Polls.Fields.EndDate")]
        [UIHint("DateTimeNullable")]
        public DateTime? EndDateUtc { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Polls.Fields.LimitedToStores")]
        public IList<int> SelectedStoreIds { get; set; }

        public IList<SelectListItem> AvailableStores { get; set; }

        public PollAnswerSearchModel PollAnswerSearchModel { get; set; }

        #endregion
    }
}