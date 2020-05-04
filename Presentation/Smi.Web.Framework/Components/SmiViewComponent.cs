using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Smi.Core.Infrastructure;
using Smi.Services.Events;
using Smi.Web.Framework.Events;
using Smi.Web.Framework.Models;

namespace Smi.Web.Framework.Components
{
    /// <summary>
    /// Base class for ViewComponent in SmiMarketplace
    /// </summary>
    public abstract class SmiViewComponent : ViewComponent
    {
        private void PublishModelPrepared<TModel>(TModel model)
        {
            //Components are not part of the controller life cycle.
            //Hence, we could no longer use Action Filters to intercept the Models being returned
            //as we do in the /Smi.Web.Framework/Mvc/Filters/PublishModelEventsAttribute.cs for controllers

            //model prepared event
            if (model is BaseSmiModel)
            {
                var eventPublisher = EngineContext.Current.Resolve<IEventPublisher>();

                //we publish the ModelPrepared event for all models as the BaseSmiModel, 
                //so you need to implement IConsumer<ModelPrepared<BaseSmiModel>> interface to handle this event
                eventPublisher.ModelPrepared(model as BaseSmiModel);
            }

            if (model is IEnumerable<BaseSmiModel> modelCollection)
            {
                var eventPublisher = EngineContext.Current.Resolve<IEventPublisher>();

                //we publish the ModelPrepared event for collection as the IEnumerable<BaseSmiModel>, 
                //so you need to implement IConsumer<ModelPrepared<IEnumerable<BaseSmiModel>>> interface to handle this event
                eventPublisher.ModelPrepared(modelCollection);
            }
        }
        /// <summary>
        /// Returns a result which will render the partial view with name <paramref name="viewName"/>.
        /// </summary>
        /// <param name="viewName">The name of the partial view to render.</param>
        /// <param name="model">The model object for the view.</param>
        /// <returns>A <see cref="ViewViewComponentResult"/>.</returns>
        public new ViewViewComponentResult View<TModel>(string viewName, TModel model)
        {
            PublishModelPrepared(model);

            //invoke the base method
            return base.View<TModel>(viewName, model);
        }

        /// <summary>
        /// Returns a result which will render the partial view
        /// </summary>
        /// <param name="model">The model object for the view.</param>
        /// <returns>A <see cref="ViewViewComponentResult"/>.</returns>
        public new ViewViewComponentResult View<TModel>(TModel model)
        {
            PublishModelPrepared(model);

            //invoke the base method
            return base.View<TModel>(model);
        }

        /// <summary>
        ///  Returns a result which will render the partial view with name viewName
        /// </summary>
        /// <param name="viewName">The name of the partial view to render.</param>
        /// <returns>A <see cref="ViewViewComponentResult"/>.</returns>
        public new ViewViewComponentResult View(string viewName)
        {
            //invoke the base method
            return base.View(viewName);
        }
    }
}