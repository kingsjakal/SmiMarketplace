using Smi.Core.Domain.Customers;
using Smi.Core.Domain.Directory;
using Smi.Core.Domain.Localization;
using Smi.Core.Domain.Tax;
using Smi.Core.Domain.Vendors;

namespace Smi.Core
{
    /// <summary>
    /// Represents work context
    /// </summary>
    public interface IWorkContext
    {
        /// <summary>
        /// Gets or sets the current customer
        /// </summary>
        Customer CurrentCustomer { get; set; }

        /// <summary>
        /// Gets the original customer (in case the current one is impersonated)
        /// </summary>
        Customer OriginalCustomerIfImpersonated { get; }

        /// <summary>
        /// Gets the current vendor (logged-in manager)
        /// </summary>
        Vendor CurrentVendor { get; }

        /// <summary>
        /// Gets or sets current user working language
        /// </summary>
        Language WorkingLanguage { get; set; }

        /// <summary>
        /// Gets or sets current user working currency
        /// </summary>
        Currency WorkingCurrency { get; set; }

        /// <summary>
        /// Gets or sets current tax display type
        /// </summary>
        TaxDisplayType TaxDisplayType { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether we're in admin area
        /// </summary>
        bool IsAdmin { get; set; }
    }
}
