using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Catalog;
using Smi.Core.Domain.Discounts;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Discounts
{
    /// <summary>
    /// Represents a discount category mapping entity builder
    /// </summary>
    public partial class DiscountCategoryMappingBuilder : SmiEntityBuilder<DiscountCategoryMapping>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(NameCompatibilityManager.GetColumnName(typeof(DiscountCategoryMapping), nameof(DiscountCategoryMapping.DiscountId)))
                    .AsInt32().PrimaryKey().ForeignKey<Discount>()
                .WithColumn(NameCompatibilityManager.GetColumnName(typeof(DiscountCategoryMapping), nameof(DiscountCategoryMapping.EntityId)))
                    .AsInt32().PrimaryKey().ForeignKey<Category>();
        }

        #endregion
    }
}