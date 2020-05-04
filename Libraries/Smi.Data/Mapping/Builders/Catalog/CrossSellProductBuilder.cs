using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Catalog;

namespace Smi.Data.Mapping.Builders.Catalog
{
    /// <summary>
    /// Represents a cross sell product entity builder
    /// </summary>
    public partial class CrossSellProductBuilder : SmiEntityBuilder<CrossSellProduct>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
        }

        #endregion
    }
}