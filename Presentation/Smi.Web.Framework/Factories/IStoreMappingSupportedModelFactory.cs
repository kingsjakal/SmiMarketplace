﻿using Smi.Core;
using Smi.Core.Domain.Stores;
using Smi.Web.Framework.Models;

namespace Smi.Web.Framework.Factories
{
    /// <summary>
    /// Represents the store mapping supported model factory
    /// </summary>
    public partial interface IStoreMappingSupportedModelFactory
    {
        /// <summary>
        /// Prepare selected and all available stores for the passed model
        /// </summary>
        /// <typeparam name="TModel">Store mapping supported model type</typeparam>
        /// <param name="model">Model</param>
        void PrepareModelStores<TModel>(TModel model) where TModel : IStoreMappingSupportedModel;

        /// <summary>
        /// Prepare selected and all available stores for the passed model by store mappings
        /// </summary>
        /// <typeparam name="TModel">Store mapping supported model type</typeparam>
        /// <typeparam name="TEntity">Store mapping supported entity type</typeparam>
        /// <param name="model">Model</param>
        /// <param name="entity">Entity</param>
        /// <param name="ignoreStoreMappings">Whether to ignore existing store mappings</param>
        void PrepareModelStores<TModel, TEntity>(TModel model, TEntity entity, bool ignoreStoreMappings)
            where TModel : IStoreMappingSupportedModel where TEntity : BaseEntity, IStoreMappingSupported;
    }
}