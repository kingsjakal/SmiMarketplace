using System.Data;
using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Affiliates;
using Smi.Core.Domain.Common;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Affiliates
{
    /// <summary>
    /// Represents a affiliate entity builder
    /// </summary>
    public class AffiliateBuilder : SmiEntityBuilder<Affiliate>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(Affiliate.AddressId)).AsInt32().ForeignKey<Address>().OnDelete(Rule.None);
        }

        #endregion
    }
}