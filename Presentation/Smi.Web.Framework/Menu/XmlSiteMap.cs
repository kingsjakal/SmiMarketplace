﻿//code from Telerik MVC Extensions

using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using Microsoft.AspNetCore.Routing;
using Smi.Core.Infrastructure;
using Smi.Services.Localization;
using Smi.Services.Security;

namespace Smi.Web.Framework.Menu
{
    /// <summary>
    /// XML sitemap
    /// </summary>
    public class XmlSiteMap
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public XmlSiteMap()
        {
            RootNode = new SiteMapNode();
        }

        /// <summary>
        /// Root node
        /// </summary>
        public SiteMapNode RootNode { get; set; }

        /// <summary>
        /// Load sitemap
        /// </summary>
        /// <param name="physicalPath">Filepath to load a sitemap</param>
        public virtual void LoadFrom(string physicalPath)
        {
            var fileProvider = EngineContext.Current.Resolve<ISmiFileProvider>();

            var filePath = fileProvider.MapPath(physicalPath);
            var content = fileProvider.ReadAllText(filePath, Encoding.UTF8);

            if (!string.IsNullOrEmpty(content))
            {
                var doc = new XmlDocument();
                using (var sr = new StringReader(content))
                {
                    using var xr = XmlReader.Create(sr,
                        new XmlReaderSettings
                        {
                            CloseInput = true,
                            IgnoreWhitespace = true,
                            IgnoreComments = true,
                            IgnoreProcessingInstructions = true
                        });

                    doc.Load(xr);
                }
                if ((doc.DocumentElement != null) && doc.HasChildNodes)
                {
                    var xmlRootNode = doc.DocumentElement.FirstChild;
                    Iterate(RootNode, xmlRootNode);
                }
            }
        }

        private static void Iterate(SiteMapNode siteMapNode, XmlNode xmlNode)
        {
            PopulateNode(siteMapNode, xmlNode);

            foreach (XmlNode xmlChildNode in xmlNode.ChildNodes)
            {
                if (xmlChildNode.LocalName.Equals("siteMapNode", StringComparison.InvariantCultureIgnoreCase))
                {
                    var siteMapChildNode = new SiteMapNode();
                    siteMapNode.ChildNodes.Add(siteMapChildNode);

                    Iterate(siteMapChildNode, xmlChildNode);
                }
            }
        }

        private static void PopulateNode(SiteMapNode siteMapNode, XmlNode xmlNode)
        {
            //system name
            siteMapNode.SystemName = GetStringValueFromAttribute(xmlNode, "SystemName");

            //title
            var SmiResource = GetStringValueFromAttribute(xmlNode, "SmiResource");
            var localizationService = EngineContext.Current.Resolve<ILocalizationService>();
            siteMapNode.Title = localizationService.GetResource(SmiResource);

            //routes, url
            var controllerName = GetStringValueFromAttribute(xmlNode, "controller");
            var actionName = GetStringValueFromAttribute(xmlNode, "action");
            var url = GetStringValueFromAttribute(xmlNode, "url");
            if (!string.IsNullOrEmpty(controllerName) && !string.IsNullOrEmpty(actionName))
            {
                siteMapNode.ControllerName = controllerName;
                siteMapNode.ActionName = actionName;

                //apply admin area as described here - https://www.SmiMarketplace.com/boards/topic/20478/broken-menus-in-admin-area-whilst-trying-to-make-a-plugin-admin-page
                siteMapNode.RouteValues = new RouteValueDictionary { { "area", AreaNames.Admin } };
            }
            else if (!string.IsNullOrEmpty(url))
            {
                siteMapNode.Url = url;
            }

            //image URL
            siteMapNode.IconClass = GetStringValueFromAttribute(xmlNode, "IconClass");

            //permission name
            var permissionNames = GetStringValueFromAttribute(xmlNode, "PermissionNames");
            if (!string.IsNullOrEmpty(permissionNames))
            {
                var permissionService = EngineContext.Current.Resolve<IPermissionService>();
                siteMapNode.Visible = permissionNames.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                   .Any(permissionName => permissionService.Authorize(permissionName.Trim()));
            }
            else
            {
                siteMapNode.Visible = true;
            }

            // Open URL in new tab
            var openUrlInNewTabValue = GetStringValueFromAttribute(xmlNode, "OpenUrlInNewTab");
            if (!string.IsNullOrWhiteSpace(openUrlInNewTabValue) && bool.TryParse(openUrlInNewTabValue, out var booleanResult))
            {
                siteMapNode.OpenUrlInNewTab = booleanResult;
            }
        }

        private static string GetStringValueFromAttribute(XmlNode node, string attributeName)
        {
            string value = null;

            if (node.Attributes != null && node.Attributes.Count > 0)
            {
                var attribute = node.Attributes[attributeName];

                if (attribute != null)
                {
                    value = attribute.Value;
                }
            }

            return value;
        }
    }
}
