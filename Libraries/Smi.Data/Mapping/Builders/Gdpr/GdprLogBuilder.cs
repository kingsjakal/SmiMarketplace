using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Gdpr;

namespace Smi.Data.Mapping.Builders.Gdpr
{
    /// <summary>
    /// Represents a GDPR log entity builder
    /// </summary>
    public partial class GdprLogBuilder : SmiEntityBuilder<GdprLog>
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