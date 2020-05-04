using Smi.Web.Areas.Admin.Models.Home;

namespace Smi.Web.Areas.Admin.Factories
{
    /// <summary>
    /// Represents the home models factory
    /// </summary>
    public partial interface IHomeModelFactory
    {
        /// <summary>
        /// Prepare dashboard model
        /// </summary>
        /// <param name="model">Dashboard model</param>
        /// <returns>Dashboard model</returns>
        DashboardModel PrepareDashboardModel(DashboardModel model);

        /// <summary>
        /// Prepare SmiMarketplace news model
        /// </summary>
        /// <returns>SmiMarketplace news model</returns>
        SmiMarketplaceNewsModel PrepareSmiMarketplaceNewsModel();
    }
}