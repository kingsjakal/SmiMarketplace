using System;
using System.Collections.Generic;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.News
{
    public partial class HomepageNewsItemsModel : BaseSmiModel, ICloneable
    {
        public HomepageNewsItemsModel()
        {
            NewsItems = new List<NewsItemModel>();
        }

        public int WorkingLanguageId { get; set; }
        public IList<NewsItemModel> NewsItems { get; set; }

        public object Clone()
        {
            //we use a shallow copy (deep clone is not required here)
            return MemberwiseClone();
        }
    }
}