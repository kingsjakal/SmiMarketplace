﻿using System;
using System.Collections.Generic;
using System.Linq;
using Smi.Services.Customers;
using Smi.Services.Localization;
using Smi.Services.Security;
using Smi.Web.Areas.Admin.Infrastructure.Mapper.Extensions;
using Smi.Web.Areas.Admin.Models.Customers;
using Smi.Web.Areas.Admin.Models.Security;

namespace Smi.Web.Areas.Admin.Factories
{
    /// <summary>
    /// Represents the security model factory implementation
    /// </summary>
    public partial class SecurityModelFactory : ISecurityModelFactory
    {
        #region Fields

        private readonly ICustomerService _customerService;
        private readonly ILocalizationService _localizationService;
        private readonly IPermissionService _permissionService;

        #endregion

        #region Ctor

        public SecurityModelFactory(ICustomerService customerService,
            ILocalizationService localizationService,
            IPermissionService permissionService)
        {
            _customerService = customerService;
            _localizationService = localizationService;
            _permissionService = permissionService;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Prepare permission mapping model
        /// </summary>
        /// <param name="model">Permission mapping model</param>
        /// <returns>Permission mapping model</returns>
        public virtual PermissionMappingModel PreparePermissionMappingModel(PermissionMappingModel model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            var customerRoles = _customerService.GetAllCustomerRoles(true);
            model.AvailableCustomerRoles = customerRoles.Select(role => role.ToModel<CustomerRoleModel>()).ToList();

            foreach (var permissionRecord in _permissionService.GetAllPermissionRecords())
            {
                model.AvailablePermissions.Add(new PermissionRecordModel
                {
                    Name = _localizationService.GetLocalizedPermissionName(permissionRecord),
                    SystemName = permissionRecord.SystemName
                });

                foreach (var role in customerRoles)
                {
                    if (!model.Allowed.ContainsKey(permissionRecord.SystemName))
                        model.Allowed[permissionRecord.SystemName] = new Dictionary<int, bool>();
                    model.Allowed[permissionRecord.SystemName][role.Id] = 
                        _permissionService.GetMappingByPermissionRecordId(permissionRecord.Id).Any(mapping => mapping.CustomerRoleId == role.Id);
                }
            }

            return model;
        }

        #endregion
    }
}