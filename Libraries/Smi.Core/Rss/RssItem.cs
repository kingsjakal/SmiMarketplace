using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Smi.Core.Rss
{
    /// <summary>
    /// Represents the item of RSS feed
    /// </summary>
    public partial class RssItem
    {
        /// <summary>
        /// Initialize new instance of RSS feed item
        /// </summary>
        /// <param name="title">Title</param>
        /// <param name="content">Content</param>
        /// <param name="link">Link</param>
        /// <param name="id">Unique identifier</param>
        /// <param name="pubDate">Last build date</param>
        public RssItem(string title, string content, Uri link, string id, DateTimeOffset pubDate)
        {
            Title = new XElement(SmiRssDefaults.Title, title);
            Content = new XElement(SmiRssDefaults.Description, content);
            Link = new XElement(SmiRssDefaults.Link, link);
            Id = new XElement(SmiRssDefaults.Guid, new XAttribute("isPermaLink", false), id);
            PubDate = new XElement(SmiRssDefaults.PubDate, pubDate.ToString("r"));
        }

        /// <summary>
        /// Initialize new instance of RSS feed item
        /// </summary>
        /// <param name="item">XML view of rss item</param>
        public RssItem(XContainer item)
        {
            var title = item.Element(SmiRssDefaults.Title)?.Value ?? string.Empty;
            var content = item.Element(SmiRssDefaults.Content)?.Value ?? string.Empty;
            if (string.IsNullOrEmpty(content))
                content = item.Element(SmiRssDefaults.Description)?.Value ?? string.Empty;
            var link = new Uri(item.Element(SmiRssDefaults.Link)?.Value ?? string.Empty);
            var pubDateValue = item.Element(SmiRssDefaults.PubDate)?.Value;
            var pubDate = pubDateValue == null ? DateTimeOffset.Now : DateTimeOffset.ParseExact(pubDateValue, "r", null);
            var id = item.Element(SmiRssDefaults.Guid)?.Value ?? string.Empty;

            Title = new XElement(SmiRssDefaults.Title, title);
            Content = new XElement(SmiRssDefaults.Description, content);
            Link = new XElement(SmiRssDefaults.Link, link);
            Id = new XElement(SmiRssDefaults.Guid, new XAttribute("isPermaLink", false), id);
            PubDate = new XElement(SmiRssDefaults.PubDate, pubDate.ToString("r"));
        }

        #region Methods

        /// <summary>
        /// Get representation item of RSS feed as XElement object
        /// </summary>
        /// <returns></returns>
        public XElement ToXElement()
        {
            var element = new XElement(SmiRssDefaults.Item, Id, Link, Title, Content);

            foreach (var elementExtensions in ElementExtensions)
            {
                element.Add(elementExtensions);
            }

            return element;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Title
        /// </summary>
        public XElement Title { get; private set; }

        /// <summary>
        /// Get title text
        /// </summary>
        public string TitleText => Title?.Value ?? string.Empty;

        /// <summary>
        /// Content
        /// </summary>
        public XElement Content { get; private set; }

        /// <summary>
        /// Get content text
        /// </summary>
        public string ContentText => XmlHelper.XmlDecode(Content?.Value ?? string.Empty);

        /// <summary>
        /// Link
        /// </summary>
        public XElement Link { get; private set; }

        /// <summary>
        /// Get URL
        /// </summary>
        public Uri Url => new Uri(Link.Value);

        /// <summary>
        /// Unique identifier
        /// </summary>
        public XElement Id { get; private set; }

        /// <summary>
        /// Last build date
        /// </summary>
        public XElement PubDate { get; private set; }

        /// <summary>
        /// Publish date
        /// </summary>
        public DateTimeOffset PublishDate => PubDate?.Value == null ? DateTimeOffset.Now : DateTimeOffset.ParseExact(PubDate.Value, "r", null);

        /// <summary>
        /// Element extensions
        /// </summary>
        public List<XElement> ElementExtensions { get; } = new List<XElement>();

        #endregion
    }
}