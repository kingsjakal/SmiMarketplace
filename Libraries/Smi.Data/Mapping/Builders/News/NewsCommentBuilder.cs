using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Customers;
using Smi.Core.Domain.News;
using Smi.Core.Domain.Stores;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.News
{
    /// <summary>
    /// Represents a news comment entity builder
    /// </summary>
    public partial class NewsCommentBuilder : SmiEntityBuilder<NewsComment>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(NewsComment.CustomerId)).AsInt32().ForeignKey<Customer>()
                .WithColumn(nameof(NewsComment.NewsItemId)).AsInt32().ForeignKey<NewsItem>()
                .WithColumn(nameof(NewsComment.StoreId)).AsInt32().ForeignKey<Store>();
        }

        #endregion
    }
}