﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Smi.Core;
using Smi.Core.Domain.Blogs;
using Smi.Core.Domain.Localization;
using Smi.Core.Domain.Security;
using Smi.Core.Rss;
using Smi.Services.Blogs;
using Smi.Services.Customers;
using Smi.Services.Events;
using Smi.Services.Localization;
using Smi.Services.Logging;
using Smi.Services.Messages;
using Smi.Services.Security;
using Smi.Services.Seo;
using Smi.Services.Stores;
using Smi.Web.Factories;
using Smi.Web.Framework;
using Smi.Web.Framework.Controllers;
using Smi.Web.Framework.Mvc;
using Smi.Web.Framework.Mvc.Filters;
using Smi.Web.Models.Blogs;

namespace Smi.Web.Controllers
{
    [AutoValidateAntiforgeryToken]
    public partial class BlogController : BasePublicController
    {
        #region Fields

        private readonly BlogSettings _blogSettings;
        private readonly CaptchaSettings _captchaSettings;
        private readonly IBlogModelFactory _blogModelFactory;
        private readonly IBlogService _blogService;
        private readonly ICustomerActivityService _customerActivityService;
        private readonly ICustomerService _customerService;
        private readonly IEventPublisher _eventPublisher;
        private readonly ILocalizationService _localizationService;
        private readonly IPermissionService _permissionService;
        private readonly IStoreContext _storeContext;
        private readonly IStoreMappingService _storeMappingService;
        private readonly IUrlRecordService _urlRecordService;
        private readonly IWebHelper _webHelper;
        private readonly IWorkContext _workContext;
        private readonly IWorkflowMessageService _workflowMessageService;
        private readonly LocalizationSettings _localizationSettings;

        #endregion

        #region Ctor

        public BlogController(BlogSettings blogSettings,
            CaptchaSettings captchaSettings,
            IBlogModelFactory blogModelFactory,
            IBlogService blogService,
            ICustomerActivityService customerActivityService,
            ICustomerService customerService,
            IEventPublisher eventPublisher,
            ILocalizationService localizationService,
            IPermissionService permissionService,
            IStoreContext storeContext,
            IStoreMappingService storeMappingService,
            IUrlRecordService urlRecordService,
            IWebHelper webHelper,
            IWorkContext workContext,
            IWorkflowMessageService workflowMessageService,
            LocalizationSettings localizationSettings)
        {
            _blogSettings = blogSettings;
            _captchaSettings = captchaSettings;
            _blogModelFactory = blogModelFactory;
            _blogService = blogService;
            _customerActivityService = customerActivityService;
            _customerService = customerService;
            _eventPublisher = eventPublisher;
            _localizationService = localizationService;
            _permissionService = permissionService;
            _storeContext = storeContext;
            _storeMappingService = storeMappingService;
            _urlRecordService = urlRecordService;
            _webHelper = webHelper;
            _workContext = workContext;
            _workflowMessageService = workflowMessageService;
            _localizationSettings = localizationSettings;
        }

        #endregion

        #region Methods

        public virtual IActionResult List(BlogPagingFilteringModel command)
        {
            if (!_blogSettings.Enabled)
                return RedirectToRoute("Homepage");

            var model = _blogModelFactory.PrepareBlogPostListModel(command);
            return View("List", model);
        }

        public virtual IActionResult BlogByTag(BlogPagingFilteringModel command)
        {
            if (!_blogSettings.Enabled)
                return RedirectToRoute("Homepage");

            var model = _blogModelFactory.PrepareBlogPostListModel(command);
            return View("List", model);
        }

        public virtual IActionResult BlogByMonth(BlogPagingFilteringModel command)
        {
            if (!_blogSettings.Enabled)
                return RedirectToRoute("Homepage");

            var model = _blogModelFactory.PrepareBlogPostListModel(command);
            return View("List", model);
        }

        public virtual IActionResult ListRss(int languageId)
        {
            var feed = new RssFeed(
                $"{_localizationService.GetLocalized(_storeContext.CurrentStore, x => x.Name)}: Blog",
                "Blog",
                new Uri(_webHelper.GetStoreLocation()),
                DateTime.UtcNow);

            if (!_blogSettings.Enabled)
                return new RssActionResult(feed, _webHelper.GetThisPageUrl(false));

            var items = new List<RssItem>();
            var blogPosts = _blogService.GetAllBlogPosts(_storeContext.CurrentStore.Id, languageId);
            foreach (var blogPost in blogPosts)
            {
                var blogPostUrl = Url.RouteUrl("BlogPost", new { SeName = _urlRecordService.GetSeName(blogPost, blogPost.LanguageId, ensureTwoPublishedLanguages: false) }, _webHelper.CurrentRequestProtocol);
                items.Add(new RssItem(blogPost.Title, blogPost.Body, new Uri(blogPostUrl),
                    $"urn:store:{_storeContext.CurrentStore.Id}:blog:post:{blogPost.Id}", blogPost.CreatedOnUtc));
            }
            feed.Items = items;
            return new RssActionResult(feed, _webHelper.GetThisPageUrl(false));
        }

        public virtual IActionResult BlogPost(int blogPostId)
        {
            if (!_blogSettings.Enabled)
                return RedirectToRoute("Homepage");

            var blogPost = _blogService.GetBlogPostById(blogPostId);
            if (blogPost == null)
                return InvokeHttp404();

            var notAvailable =
                //availability dates
                !_blogService.BlogPostIsAvailable(blogPost) ||
                //Store mapping
                !_storeMappingService.Authorize(blogPost);
            //Check whether the current user has a "Manage blog" permission (usually a store owner)
            //We should allows him (her) to use "Preview" functionality
            var hasAdminAccess = _permissionService.Authorize(StandardPermissionProvider.AccessAdminPanel) && _permissionService.Authorize(StandardPermissionProvider.ManageBlog);
            if (notAvailable && !hasAdminAccess)
                return InvokeHttp404();

            //display "edit" (manage) link
            if (hasAdminAccess)
                DisplayEditLink(Url.Action("BlogPostEdit", "Blog", new { id = blogPost.Id, area = AreaNames.Admin }));

            var model = new BlogPostModel();
            _blogModelFactory.PrepareBlogPostModel(model, blogPost, true);

            return View(model);
        }

        [HttpPost, ActionName("BlogPost")]        
        [FormValueRequired("add-comment")]
        [ValidateCaptcha]
        public virtual IActionResult BlogCommentAdd(int blogPostId, BlogPostModel model, bool captchaValid)
        {
            if (!_blogSettings.Enabled)
                return RedirectToRoute("Homepage");

            var blogPost = _blogService.GetBlogPostById(blogPostId);
            if (blogPost == null || !blogPost.AllowComments)
                return RedirectToRoute("Homepage");

            if (_customerService.IsGuest(_workContext.CurrentCustomer) && !_blogSettings.AllowNotRegisteredUsersToLeaveComments)
            {
                ModelState.AddModelError("", _localizationService.GetResource("Blog.Comments.OnlyRegisteredUsersLeaveComments"));
            }

            //validate CAPTCHA
            if (_captchaSettings.Enabled && _captchaSettings.ShowOnBlogCommentPage && !captchaValid)
            {
                ModelState.AddModelError("", _localizationService.GetResource("Common.WrongCaptchaMessage"));
            }

            if (ModelState.IsValid)
            {
                var comment = new BlogComment
                {
                    BlogPostId = blogPost.Id,
                    CustomerId = _workContext.CurrentCustomer.Id,
                    CommentText = model.AddNewComment.CommentText,
                    IsApproved = !_blogSettings.BlogCommentsMustBeApproved,
                    StoreId = _storeContext.CurrentStore.Id,
                    CreatedOnUtc = DateTime.UtcNow,
                };

                _blogService.InsertBlogComment(comment);

                //notify a store owner
                if (_blogSettings.NotifyAboutNewBlogComments)
                    _workflowMessageService.SendBlogCommentNotificationMessage(comment, _localizationSettings.DefaultAdminLanguageId);

                //activity log
                _customerActivityService.InsertActivity("PublicStore.AddBlogComment",
                    _localizationService.GetResource("ActivityLog.PublicStore.AddBlogComment"), comment);

                //raise event
                if (comment.IsApproved)
                    _eventPublisher.Publish(new BlogCommentApprovedEvent(comment));

                //The text boxes should be cleared after a comment has been posted
                //That' why we reload the page
                TempData["Smi.blog.addcomment.result"] = comment.IsApproved
                    ? _localizationService.GetResource("Blog.Comments.SuccessfullyAdded")
                    : _localizationService.GetResource("Blog.Comments.SeeAfterApproving");
                return RedirectToRoute("BlogPost", new { SeName = _urlRecordService.GetSeName(blogPost, blogPost.LanguageId, ensureTwoPublishedLanguages: false) });
            }

            //If we got this far, something failed, redisplay form
            _blogModelFactory.PrepareBlogPostModel(model, blogPost, true);
            return View(model);
        }

        #endregion
    }
}