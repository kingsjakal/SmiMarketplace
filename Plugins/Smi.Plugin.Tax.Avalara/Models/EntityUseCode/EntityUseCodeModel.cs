using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Plugin.Tax.Avalara.Models.EntityUseCode
{
    /// <summary>
    /// Represents an entity use code model
    /// </summary>
    public class EntityUseCodeModel : BaseSmiEntityModel
    {
        #region Ctor

        public EntityUseCodeModel()
        {
            EntityUseCodes = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        public string PrecedingElementId { get; set; }

        [SmiResourceDisplayName("Plugins.Tax.Avalara.Fields.EntityUseCode")]
        public string AvalaraEntityUseCode { get; set; }
        public List<SelectListItem> EntityUseCodes { get; set; }

        #endregion
    }
}