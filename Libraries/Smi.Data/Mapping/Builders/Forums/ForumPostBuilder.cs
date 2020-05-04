using System.Data;
using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Customers;
using Smi.Core.Domain.Forums;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Forums
{
    /// <summary>
    /// Represents a forum post entity builder
    /// </summary>
    public partial class ForumPostBuilder : SmiEntityBuilder<ForumPost>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(ForumPost.Text)).AsString(int.MaxValue).NotNullable()
                .WithColumn(nameof(ForumPost.IPAddress)).AsString(100).Nullable()
                .WithColumn(nameof(ForumPost.CustomerId)).AsInt32().ForeignKey<Customer>().OnDelete(Rule.None)
                .WithColumn(nameof(ForumPost.TopicId)).AsInt32().ForeignKey<ForumTopic>();
        }

        #endregion
    }
}