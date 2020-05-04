using System.Collections.Generic;
using Smi.Web.Framework.Models;
using Smi.Web.Models.Common;

namespace Smi.Web.Models.Boards
{
    public partial class CustomerForumSubscriptionsModel : BaseSmiModel
    {
        public CustomerForumSubscriptionsModel()
        {
            ForumSubscriptions = new List<ForumSubscriptionModel>();
        }

        public IList<ForumSubscriptionModel> ForumSubscriptions { get; set; }
        public PagerModel PagerModel { get; set; }

        #region Nested classes

        public partial class ForumSubscriptionModel : BaseSmiEntityModel
        {
            public int ForumId { get; set; }
            public int ForumTopicId { get; set; }
            public bool TopicSubscription { get; set; }
            public string Title { get; set; }
            public string Slug { get; set; }
        }

        #endregion
    }
}