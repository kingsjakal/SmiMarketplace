using FluentMigrator.Builders.Create.Table;
using Smi.Data.Mapping.Builders;
using Smi.Plugin.Shipping.FixedByWeightByTotal.Domain;

namespace Smi.Plugin.Shipping.FixedByWeightByTotal.Data
{
    public class ShippingByWeightByTotalRecordBuilder : SmiEntityBuilder<ShippingByWeightByTotalRecord>
    {
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(ShippingByWeightByTotalRecord.WeightFrom))
                .AsDecimal(18, 2)
                .WithColumn(nameof(ShippingByWeightByTotalRecord.WeightTo))
                .AsDecimal(18, 2)
                .WithColumn(nameof(ShippingByWeightByTotalRecord.OrderSubtotalFrom))
                .AsDecimal(18, 2)
                .WithColumn(nameof(ShippingByWeightByTotalRecord.OrderSubtotalTo))
                .AsDecimal(18, 2)
                .WithColumn(nameof(ShippingByWeightByTotalRecord.AdditionalFixedCost))
                .AsDecimal(18, 2)
                .WithColumn(nameof(ShippingByWeightByTotalRecord.PercentageRateOfSubtotal))
                .AsDecimal(18, 2)
                .WithColumn(nameof(ShippingByWeightByTotalRecord.RatePerWeightUnit))
                .AsDecimal(18, 2)
                .WithColumn(nameof(ShippingByWeightByTotalRecord.LowerWeightLimit))
                .AsDecimal(18, 2)
                .WithColumn(nameof(ShippingByWeightByTotalRecord.Zip))
                .AsString(400)
                .Nullable();
        }
    }
}