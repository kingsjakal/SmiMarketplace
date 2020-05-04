using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Plugin.Pickup.PickupInStore.Models
{
    public class StorePickupPointModel : BaseSmiEntityModel
    {
        public StorePickupPointModel()
        {
            Address = new AddressModel();
            AvailableStores = new List<SelectListItem>();
        }

        public AddressModel Address { get; set; }

        [SmiResourceDisplayName("Plugins.Pickup.PickupInStore.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Plugins.Pickup.PickupInStore.Fields.Description")]
        public string Description { get; set; }

        [SmiResourceDisplayName("Plugins.Pickup.PickupInStore.Fields.PickupFee")]
        public decimal PickupFee { get; set; }

        [SmiResourceDisplayName("Plugins.Pickup.PickupInStore.Fields.OpeningHours")]
        public string OpeningHours { get; set; }

        [SmiResourceDisplayName("Plugins.Pickup.PickupInStore.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public List<SelectListItem> AvailableStores { get; set; }
        [SmiResourceDisplayName("Plugins.Pickup.PickupInStore.Fields.Store")]
        public int StoreId { get; set; }
        public string StoreName { get; set; }

        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0:F8}", ApplyFormatInEditMode = true)]
        [SmiResourceDisplayName("Plugins.Pickup.PickupInStore.Fields.Latitude")]
        public decimal? Latitude { get; set; }

        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0:F8}", ApplyFormatInEditMode = true)]
        [SmiResourceDisplayName("Plugins.Pickup.PickupInStore.Fields.Longitude")]
        public decimal? Longitude { get; set; }

        [UIHint("Int32Nullable")]
        [SmiResourceDisplayName("Plugins.Pickup.PickupInStore.Fields.TransitDays")]
        public int? TransitDays { get; set; }
    }

    public class AddressModel
    {
        public AddressModel()
        {
            AvailableCountries = new List<SelectListItem>();
            AvailableStates = new List<SelectListItem>();
        }

        [SmiResourceDisplayName("Admin.Address.Fields.Country")]
        public int? CountryId { get; set; }
        public IList<SelectListItem> AvailableCountries { get; set; }
        public bool CountryEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Address.Fields.StateProvince")]
        public int? StateProvinceId { get; set; }
        public IList<SelectListItem> AvailableStates { get; set; }
        public bool StateProvinceEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Address.Fields.County")]
        public string County { get; set; }
        public bool CountyEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Address.Fields.City")]
        public string City { get; set; }
        public bool CityEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Address.Fields.Address1")]
        public string Address1 { get; set; }

        [SmiResourceDisplayName("Admin.Address.Fields.ZipPostalCode")]
        public string ZipPostalCode { get; set; }
        public bool ZipPostalCodeEnabled { get; set; }
    }
}