using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Models;

namespace Smi.Plugin.Tax.Avalara.Models.Tax
{
    /// <summary>
    /// Represents a tax category search model
    /// </summary>
    public class TaxCategorySearchModel : BaseSearchModel
    {
        #region Ctor

        public TaxCategorySearchModel()
        {
            AddTaxCategory = new TaxCategoryModel();
            AvailableTypes = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        public TaxCategoryModel AddTaxCategory { get; set; }

        public IList<SelectListItem> AvailableTypes { get; set; }

        #endregion
    }
}