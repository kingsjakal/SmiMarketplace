using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Smi.Core.Http.Extensions;
using Smi.Core.Infrastructure;

namespace Smi.Services.Authentication.External
{
    /// <summary>
    /// External authorizer helper
    /// </summary>
    public static partial class ExternalAuthorizerHelper
    {
        #region Methods

        /// <summary>
        /// Add error
        /// </summary>
        /// <param name="error">Error</param>
        public static void AddErrorsToDisplay(string error)
        {
            var session = EngineContext.Current.Resolve<IHttpContextAccessor>().HttpContext.Session;
            var errors = session.Get<IList<string>>(SmiAuthenticationDefaults.ExternalAuthenticationErrorsSessionKey) ?? new List<string>();
            errors.Add(error);
            session.Set(SmiAuthenticationDefaults.ExternalAuthenticationErrorsSessionKey, errors);
        }

        /// <summary>
        /// Retrieve errors to display
        /// </summary>
        /// <returns>Errors</returns>
        public static IList<string> RetrieveErrorsToDisplay()
        {
            var session = EngineContext.Current.Resolve<IHttpContextAccessor>().HttpContext.Session;
            var errors = session.Get<IList<string>>(SmiAuthenticationDefaults.ExternalAuthenticationErrorsSessionKey);

            if (errors != null)
                session.Remove(SmiAuthenticationDefaults.ExternalAuthenticationErrorsSessionKey);

            return errors;
        }

        #endregion
    }
}