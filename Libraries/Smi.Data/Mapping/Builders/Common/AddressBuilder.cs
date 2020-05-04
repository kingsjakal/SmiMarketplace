using System.Data;
using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Common;
using Smi.Core.Domain.Directory;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Common
{
    /// <summary>
    /// Represents a address entity builder
    /// </summary>
    public partial class AddressBuilder : SmiEntityBuilder<Address>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(Address.CountryId)).AsInt32().Nullable().ForeignKey<Country>(onDelete: Rule.None)
                .WithColumn(nameof(Address.StateProvinceId)).AsInt32().Nullable().ForeignKey<StateProvince>(onDelete: Rule.None);
        }

        #endregion
    }
}