using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Media
{
    public partial class PictureModel : BaseSmiModel
    {
        public string ImageUrl { get; set; }

        public string ThumbImageUrl { get; set; }

        public string FullSizeImageUrl { get; set; }

        public string Title { get; set; }

        public string AlternateText { get; set; }
    }
}