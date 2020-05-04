using Microsoft.AspNetCore.Mvc;
using Smi.Web.Factories;
using Smi.Web.Framework.Mvc.Filters;

namespace Smi.Web.Controllers
{
    public partial class CountryController : BasePublicController
	{
        #region Fields

        private readonly ICountryModelFactory _countryModelFactory;
        
        #endregion
        
        #region Ctor

        public CountryController(ICountryModelFactory countryModelFactory)
		{
            _countryModelFactory = countryModelFactory;
		}
        
        #endregion
        
        #region States / provinces

        //available even when navigation is not allowed
        [CheckAccessPublicStore(true)]
        public virtual IActionResult GetStatesByCountryId(string countryId, bool addSelectStateItem)
        {
            var model = _countryModelFactory.GetStatesByCountryId(countryId, addSelectStateItem);
            return Json(model);
        }
        
        #endregion
    }
}