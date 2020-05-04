using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.ShoppingCart
{
    public partial class EstimateShippingModel : BaseSmiModel
    {
        public EstimateShippingModel()
        {
            AvailableCountries = new List<SelectListItem>();
            AvailableStates = new List<SelectListItem>();
        }

        public bool Enabled { get; set; }

        public int? CountryId { get; set; }
        public int? StateProvinceId { get; set; }
        public string ZipPostalCode { get; set; }
        
        public IList<SelectListItem> AvailableCountries { get; set; }
        public IList<SelectListItem> AvailableStates { get; set; }
    }

    public partial class EstimateShippingResultModel : BaseSmiModel
    {
        public EstimateShippingResultModel()
        {
            ShippingOptions = new List<ShippingOptionModel>();
            Warnings = new List<string>();
        }

        public IList<ShippingOptionModel> ShippingOptions { get; set; }

        public IList<string> Warnings { get; set; }

        #region Nested Classes

        public partial class ShippingOptionModel : BaseSmiModel
        {
            public string Name { get; set; }

            public string Description { get; set; }

            public string Price { get; set; }

            public decimal Rate { get; set; }

            public string DeliveryDateFormat { get; set; }
        }

        #endregion
    }
}