using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using Smi.Core.Infrastructure;
using Smi.Web.Framework.Models;

namespace Smi.Web.Framework.Mvc.ModelBinding
{
    /// <summary>
    /// Represents model binder provider for the creating SmiModelBinder
    /// </summary>
    public class SmiModelBinderProvider : IModelBinderProvider
    {
        /// <summary>
        /// Creates a Smi model binder based on passed context
        /// </summary>
        /// <param name="context">Model binder provider context</param>
        /// <returns>Model binder</returns>
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));


            var modelType = context.Metadata.ModelType;
            if (!typeof(BaseSmiModel).IsAssignableFrom(modelType))
                return null;

            //use SmiModelBinder as a ComplexTypeModelBinder for BaseSmiModel
            if (context.Metadata.IsComplexType && !context.Metadata.IsCollectionType)
            {
                //create binders for all model properties
                var propertyBinders = context.Metadata.Properties
                    .ToDictionary(modelProperty => modelProperty, modelProperty => context.CreateBinder(modelProperty));
                
                return new SmiModelBinder(propertyBinders, EngineContext.Current.Resolve<ILoggerFactory>());
            }

            //or return null to further search for a suitable binder
            return null;
        }
    }
}
