using Smi.Core.Domain.Blogs;
using Smi.Services.Caching;

namespace Smi.Services.Blogs.Caching
{
    /// <summary>
    /// Represents a blog comment cache event consumer
    /// </summary>
    public partial class BlogCommentCacheEventConsumer : CacheEventConsumer<BlogComment>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(BlogComment entity)
        {
            RemoveByPrefix(string.Format(SmiBlogsDefaults.BlogCommentsNumberPrefixCacheKey, entity.BlogPostId));
        }
    }
}