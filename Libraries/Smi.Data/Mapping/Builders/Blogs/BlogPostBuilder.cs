using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Blogs;
using Smi.Core.Domain.Localization;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Blogs
{
    /// <summary>
    /// Represents a blog post entity builder
    /// </summary>
    public partial class BlogPostBuilder : SmiEntityBuilder<BlogPost>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(BlogPost.Title)).AsString(int.MaxValue).NotNullable()
                .WithColumn(nameof(BlogPost.Body)).AsString(int.MaxValue).NotNullable()
                .WithColumn(nameof(BlogPost.MetaKeywords)).AsString(400).Nullable()
                .WithColumn(nameof(BlogPost.MetaTitle)).AsString(400).Nullable()
                .WithColumn(nameof(BlogPost.LanguageId)).AsInt32().ForeignKey<Language>();
        }

        #endregion
    }
}