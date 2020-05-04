using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Vendors;

namespace Smi.Data.Mapping.Builders.Vendors
{
    /// <summary>
    /// Represents a vendor attribute entity builder
    /// </summary>
    public partial class VendorAttributeBuilder : SmiEntityBuilder<VendorAttribute>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table.WithColumn(nameof(VendorAttribute.Name)).AsString(400).NotNullable();
        }

        #endregion
    }
}