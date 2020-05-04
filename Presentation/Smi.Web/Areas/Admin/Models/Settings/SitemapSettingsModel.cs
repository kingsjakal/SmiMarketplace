﻿using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a Sitemap settings model
    /// </summary>
    public partial class SitemapSettingsModel : BaseSmiModel, ISettingsModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.SitemapEnabled")]
        public bool SitemapEnabled { get; set; }
        public bool SitemapEnabled_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.SitemapIncludeBlogPosts")]
        public bool SitemapIncludeBlogPosts { get; set; }
        public bool SitemapIncludeBlogPosts_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.SitemapIncludeCategories")]
        public bool SitemapIncludeCategories { get; set; }
        public bool SitemapIncludeCategories_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.SitemapIncludeManufacturers")]
        public bool SitemapIncludeManufacturers { get; set; }
        public bool SitemapIncludeManufacturers_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.SitemapIncludeNews")]
        public bool SitemapIncludeNews { get; set; }
        public bool SitemapIncludeNews_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.SitemapIncludeProducts")]
        public bool SitemapIncludeProducts { get; set; }
        public bool SitemapIncludeProducts_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.SitemapIncludeProductTags")]
        public bool SitemapIncludeProductTags { get; set; }
        public bool SitemapIncludeProductTags_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.SitemapIncludeTopics")]
        public bool SitemapIncludeTopics { get; set; }
        public bool SitemapIncludeTopics_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.SitemapPageSize")]
        public int SitemapPageSize { get; set; }
        public bool SitemapPageSize_OverrideForStore { get; set; }
    }
}
