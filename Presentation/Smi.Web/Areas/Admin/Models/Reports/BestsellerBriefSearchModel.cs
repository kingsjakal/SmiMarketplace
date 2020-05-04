using Smi.Services.Orders;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Reports
{
    /// <summary>
    /// Represents a bestseller brief search model
    /// </summary>
    public partial class BestsellerBriefSearchModel : BaseSearchModel
    {
        #region Properties

        public OrderByEnum OrderBy { get; set; }

        #endregion
    }
}