using System.Collections.Generic;
using Smi.Web.Areas.Admin.Models.Stores;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a store scope configuration model
    /// </summary>
    public partial class StoreScopeConfigurationModel : BaseSmiModel
    {
        #region Ctor

        public StoreScopeConfigurationModel()
        {
            Stores = new List<StoreModel>();
        }

        #endregion

        #region Properties

        public int StoreId { get; set; }

        public IList<StoreModel> Stores { get; set; }

        #endregion
    }
}