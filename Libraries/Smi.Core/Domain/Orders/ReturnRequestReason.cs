﻿using Smi.Core.Domain.Localization;

namespace Smi.Core.Domain.Orders
{
    /// <summary>
    /// Represents a return request reason
    /// </summary>
    public partial class ReturnRequestReason : BaseEntity, ILocalizedEntity
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
