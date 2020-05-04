using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Vendors;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Vendors
{
    /// <summary>
    /// Represents a vendor note entity builder
    /// </summary>
    public partial class VendorNoteBuilder : SmiEntityBuilder<VendorNote>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(VendorNote.Note)).AsString(int.MaxValue).NotNullable()
                .WithColumn(nameof(VendorNote.VendorId)).AsInt32().ForeignKey<Vendor>();
        }

        #endregion
    }
}