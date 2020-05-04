using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Blogs;
using Smi.Core.Domain.Customers;
using Smi.Core.Domain.Stores;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Blogs
{
    /// <summary>
    /// Represents a blog comment entity builder
    /// </summary>
    public partial class BlogCommentBuilder : SmiEntityBuilder<BlogComment>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(BlogComment.StoreId)).AsInt32().ForeignKey<Store>()
                .WithColumn(nameof(BlogComment.CustomerId)).AsInt32().ForeignKey<Customer>()
                .WithColumn(nameof(BlogComment.BlogPostId)).AsInt32().ForeignKey<BlogPost>();
        }

        #endregion
    }
}