using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Customers;
using Smi.Core.Domain.Security;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Security
{
    /// <summary>
    /// Represents a ACL record entity builder
    /// </summary>
    public partial class AclRecordBuilder : SmiEntityBuilder<AclRecord>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(AclRecord.EntityName)).AsString(400).NotNullable()
                .WithColumn(nameof(AclRecord.CustomerRoleId)).AsInt32().ForeignKey<CustomerRole>();
        }

        #endregion
    }
}