using Microsoft.AspNetCore.Mvc;
using Smi.Web.Areas.Admin.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Areas.Admin.Components
{
    /// <summary>
    /// Represents a view component that displays the SmiMarketplace news
    /// </summary>
    public class SmiMarketplaceNewsViewComponent : SmiViewComponent
    {
        #region Fields

        private readonly IHomeModelFactory _homeModelFactory;

        #endregion

        #region Ctor

        public SmiMarketplaceNewsViewComponent(IHomeModelFactory homeModelFactory)
        {
            _homeModelFactory = homeModelFactory;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Invoke view component
        /// </summary>
        /// <returns>View component result</returns>
        public IViewComponentResult Invoke()
        {
            try
            {
                //prepare model
                var model = _homeModelFactory.PrepareSmiMarketplaceNewsModel();

                return View(model);
            }
            catch
            {
                return Content(string.Empty);
            }
        }

        #endregion
    }
}