using System.Data;
using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Customers;
using Smi.Core.Domain.Forums;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Forums
{
    /// <summary>
    /// Represents a forum topic entity builder
    /// </summary>
    public partial class ForumTopicBuilder : SmiEntityBuilder<ForumTopic>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(ForumTopic.Subject)).AsString(450).NotNullable()
                .WithColumn(nameof(ForumTopic.CustomerId)).AsInt32().ForeignKey<Customer>(onDelete: Rule.None)
                .WithColumn(nameof(ForumTopic.ForumId)).AsInt32().ForeignKey<Forum>();
        }

        #endregion
    }
}