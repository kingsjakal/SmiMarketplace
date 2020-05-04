﻿using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents an order note search model
    /// </summary>
    public partial class OrderNoteSearchModel : BaseSearchModel
    {
        #region Properties

        public  int OrderId { get; set; }

        #endregion
    }
}