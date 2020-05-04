using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Directory
{
    /// <summary>
    /// Represents a state and province search model
    /// </summary>
    public partial class StateProvinceSearchModel : BaseSearchModel
    {
        #region Properties

        public int CountryId { get; set; }

        #endregion
    }
}