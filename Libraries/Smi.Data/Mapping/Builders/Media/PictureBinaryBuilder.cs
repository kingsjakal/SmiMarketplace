using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Media;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Media
{
    /// <summary>
    /// Represents a picture binary entity builder
    /// </summary>
    public partial class PictureBinaryBuilder : SmiEntityBuilder<PictureBinary>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table.WithColumn(nameof(PictureBinary.PictureId)).AsInt32().ForeignKey<Picture>();
        }

        #endregion
    }
}