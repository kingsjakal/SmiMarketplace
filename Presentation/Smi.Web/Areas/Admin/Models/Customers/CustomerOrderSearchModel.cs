using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer orders search model
    /// </summary>
    public partial class CustomerOrderSearchModel : BaseSearchModel
    {
        #region Properties

        public int CustomerId { get; set; }

        #endregion
    }
}