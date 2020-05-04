﻿using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a news settings model
    /// </summary>
    public partial class NewsSettingsModel : BaseSmiModel, ISettingsModel
    {
        #region Properties

        public int ActiveStoreScopeConfiguration { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.News.Enabled")]
        public bool Enabled { get; set; }
        public bool Enabled_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.News.AllowNotRegisteredUsersToLeaveComments")]
        public bool AllowNotRegisteredUsersToLeaveComments { get; set; }
        public bool AllowNotRegisteredUsersToLeaveComments_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.News.NotifyAboutNewNewsComments")]
        public bool NotifyAboutNewNewsComments { get; set; }
        public bool NotifyAboutNewNewsComments_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.News.ShowNewsOnMainPage")]
        public bool ShowNewsOnMainPage { get; set; }
        public bool ShowNewsOnMainPage_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.News.MainPageNewsCount")]
        public int MainPageNewsCount { get; set; }
        public bool MainPageNewsCount_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.News.NewsArchivePageSize")]
        public int NewsArchivePageSize { get; set; }
        public bool NewsArchivePageSize_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.News.ShowHeaderRSSUrl")]
        public bool ShowHeaderRssUrl { get; set; }
        public bool ShowHeaderRssUrl_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.News.NewsCommentsMustBeApproved")]
        public bool NewsCommentsMustBeApproved { get; set; }
        public bool NewsCommentsMustBeApproved_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.News.ShowNewsCommentsPerStore")]
        public bool ShowNewsCommentsPerStore { get; set; }

        #endregion
    }
}