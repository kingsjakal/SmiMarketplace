using System;
using System.Collections.Generic;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Common
{
    public partial class SystemInfoModel : BaseSmiModel
    {
        public SystemInfoModel()
        {
            Headers = new List<HeaderModel>();
            LoadedAssemblies = new List<LoadedAssembly>();
        }

        [SmiResourceDisplayName("Admin.System.SystemInfo.ASPNETInfo")]
        public string AspNetInfo { get; set; }

        [SmiResourceDisplayName("Admin.System.SystemInfo.IsFullTrust")]
        public string IsFullTrust { get; set; }

        [SmiResourceDisplayName("Admin.System.SystemInfo.SmiVersion")]
        public string SmiVersion { get; set; }

        [SmiResourceDisplayName("Admin.System.SystemInfo.OperatingSystem")]
        public string OperatingSystem { get; set; }

        [SmiResourceDisplayName("Admin.System.SystemInfo.ServerLocalTime")]
        public DateTime ServerLocalTime { get; set; }

        [SmiResourceDisplayName("Admin.System.SystemInfo.ServerTimeZone")]
        public string ServerTimeZone { get; set; }

        [SmiResourceDisplayName("Admin.System.SystemInfo.UTCTime")]
        public DateTime UtcTime { get; set; }

        [SmiResourceDisplayName("Admin.System.SystemInfo.CurrentUserTime")]
        public DateTime CurrentUserTime { get; set; }

        [SmiResourceDisplayName("Admin.System.SystemInfo.CurrentStaticCacheManager")]
        public string CurrentStaticCacheManager { get; set; }

        [SmiResourceDisplayName("Admin.System.SystemInfo.HTTPHOST")]
        public string HttpHost { get; set; }

        [SmiResourceDisplayName("Admin.System.SystemInfo.Headers")]
        public IList<HeaderModel> Headers { get; set; }

        [SmiResourceDisplayName("Admin.System.SystemInfo.LoadedAssemblies")]
        public IList<LoadedAssembly> LoadedAssemblies { get; set; }

        [SmiResourceDisplayName("Admin.System.SystemInfo.RedisEnabled")]
        public bool RedisEnabled { get; set; }

        [SmiResourceDisplayName("Admin.System.SystemInfo.UseRedisToStoreDataProtectionKeys")]
        public bool UseRedisToStoreDataProtectionKeys { get; set; }

        [SmiResourceDisplayName("Admin.System.SystemInfo.UseRedisForCaching")]
        public bool UseRedisForCaching { get; set; }

        [SmiResourceDisplayName("Admin.System.SystemInfo.UseRedisToStorePluginsInfo")]
        public bool UseRedisToStorePluginsInfo { get; set; }

        [SmiResourceDisplayName("Admin.System.SystemInfo.AzureBlobStorageEnabled")]
        public bool AzureBlobStorageEnabled { get; set; }

        public partial class HeaderModel : BaseSmiModel
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public partial class LoadedAssembly : BaseSmiModel
        {
            public string FullName { get; set; }
            public string Location { get; set; }
            public bool IsDebug { get; set; }
            public DateTime? BuildDate { get; set; }
        }
    }
}