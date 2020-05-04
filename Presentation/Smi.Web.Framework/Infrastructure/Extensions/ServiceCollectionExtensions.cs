using System;
using System.Linq;
using System.Net;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using Smi.Core;
using Smi.Core.Configuration;
using Smi.Core.Domain;
using Smi.Core.Domain.Common;
using Smi.Core.Http;
using Smi.Core.Infrastructure;
using Smi.Core.Redis;
using Smi.Core.Security;
using Smi.Data;
using Smi.Services.Authentication;
using Smi.Services.Authentication.External;
using Smi.Services.Common;
using Smi.Services.Security;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Mvc.Routing;
using Smi.Web.Framework.Security.Captcha;
using Smi.Web.Framework.Themes;
using StackExchange.Profiling.Storage;
using WebMarkupMin.AspNetCore3;
using WebMarkupMin.NUglify;

namespace Smi.Web.Framework.Infrastructure.Extensions
{
    /// <summary>
    /// Represents extensions of IServiceCollection
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Add services to the application and configure service provider
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        /// <param name="configuration">Configuration of the application</param>
        /// <param name="webHostEnvironment">Hosting environment</param>
        /// <returns>Configured service provider</returns>
        public static (IEngine, SmiConfig) ConfigureApplicationServices(this IServiceCollection services,
            IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
        {
            //most of API providers require TLS 1.2 nowadays
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            //add SmiConfig configuration parameters
            var SmiConfig = services.ConfigureStartupConfig<SmiConfig>(configuration.GetSection("Smi"));

            //add hosting configuration parameters
            services.ConfigureStartupConfig<HostingConfig>(configuration.GetSection("Hosting"));

            //add accessor to HttpContext
            services.AddHttpContextAccessor();

            //create default file provider
            CommonHelper.DefaultFileProvider = new SmiFileProvider(webHostEnvironment);

            //initialize plugins
            var mvcCoreBuilder = services.AddMvcCore();
            mvcCoreBuilder.PartManager.InitializePlugins(SmiConfig);

            //create engine and configure service provider
            var engine = EngineContext.Create();

            engine.ConfigureServices(services, configuration, SmiConfig);

            return (engine, SmiConfig);
        }

        /// <summary>
        /// Create, bind and register as service the specified configuration parameters 
        /// </summary>
        /// <typeparam name="TConfig">Configuration parameters</typeparam>
        /// <param name="services">Collection of service descriptors</param>
        /// <param name="configuration">Set of key/value application configuration properties</param>
        /// <returns>Instance of configuration parameters</returns>
        public static TConfig ConfigureStartupConfig<TConfig>(this IServiceCollection services, IConfiguration configuration) where TConfig : class, new()
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            //create instance of config
            var config = new TConfig();

            //bind it to the appropriate section of configuration
            configuration.Bind(config);

            //and register it as a service
            services.AddSingleton(config);

            return config;
        }

        /// <summary>
        /// Register HttpContextAccessor
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        public static void AddHttpContextAccessor(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        /// <summary>
        /// Adds services required for anti-forgery support
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        public static void AddAntiForgery(this IServiceCollection services)
        {
            //override cookie name
            services.AddAntiforgery(options =>
            {
                options.Cookie.Name = $"{SmiCookieDefaults.Prefix}{SmiCookieDefaults.AntiforgeryCookie}";

                //whether to allow the use of anti-forgery cookies from SSL protected page on the other store pages which are not
                options.Cookie.SecurePolicy = DataSettingsManager.DatabaseIsInstalled && EngineContext.Current.Resolve<IStoreContext>().CurrentStore.SslEnabled
                    ? CookieSecurePolicy.SameAsRequest : CookieSecurePolicy.None;
            });
        }

        /// <summary>
        /// Adds services required for application session state
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        public static void AddHttpSession(this IServiceCollection services)
        {
            services.AddSession(options =>
            {
                options.Cookie.Name = $"{SmiCookieDefaults.Prefix}{SmiCookieDefaults.SessionCookie}";
                options.Cookie.HttpOnly = true;

                //whether to allow the use of session values from SSL protected page on the other store pages which are not
                options.Cookie.SecurePolicy = DataSettingsManager.DatabaseIsInstalled && EngineContext.Current.Resolve<IStoreContext>().CurrentStore.SslEnabled
                    ? CookieSecurePolicy.SameAsRequest : CookieSecurePolicy.None;
            });
        }

        /// <summary>
        /// Adds services required for themes support
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        public static void AddThemes(this IServiceCollection services)
        {
            if (!DataSettingsManager.DatabaseIsInstalled)
                return;

            //themes support
            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.ViewLocationExpanders.Add(new ThemeableViewLocationExpander());
            });
        }

        /// <summary>
        /// Adds data protection services
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        public static void AddSmiDataProtection(this IServiceCollection services)
        {
            //check whether to persist data protection in Redis
            var SmiConfig = services.BuildServiceProvider().GetRequiredService<SmiConfig>();
            if (SmiConfig.RedisEnabled && SmiConfig.UseRedisToStoreDataProtectionKeys)
            {
                //store keys in Redis
                services.AddDataProtection().PersistKeysToRedis(() =>
                {
                    var redisConnectionWrapper = EngineContext.Current.Resolve<IRedisConnectionWrapper>();
                    return redisConnectionWrapper.GetDatabase(SmiConfig.RedisDatabaseId ?? (int)RedisDatabaseNumber.DataProtectionKeys);
                }, SmiDataProtectionDefaults.RedisDataProtectionKey);
            }
            else if (SmiConfig.AzureBlobStorageEnabled && SmiConfig.UseAzureBlobStorageToStoreDataProtectionKeys)
            {
                var cloudStorageAccount = CloudStorageAccount.Parse(SmiConfig.AzureBlobStorageConnectionString);

                var client = cloudStorageAccount.CreateCloudBlobClient();
                var container = client.GetContainerReference(SmiConfig.AzureBlobStorageContainerNameForDataProtectionKeys);

                var dataProtectionBuilder = services.AddDataProtection().PersistKeysToAzureBlobStorage(container, SmiDataProtectionDefaults.AzureDataProtectionKeyFile);

                if (!SmiConfig.EncryptDataProtectionKeysWithAzureKeyVault)
                    return;

                var tokenProvider = new AzureServiceTokenProvider();
                var keyVaultClient = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(tokenProvider.KeyVaultTokenCallback));

                dataProtectionBuilder.ProtectKeysWithAzureKeyVault(keyVaultClient, SmiConfig.AzureKeyVaultIdForDataProtectionKeys);
            }
            else
            {
                var dataProtectionKeysPath = CommonHelper.DefaultFileProvider.MapPath(SmiDataProtectionDefaults.DataProtectionKeysPath);
                var dataProtectionKeysFolder = new System.IO.DirectoryInfo(dataProtectionKeysPath);

                //configure the data protection system to persist keys to the specified directory
                services.AddDataProtection().PersistKeysToFileSystem(dataProtectionKeysFolder);
            }
        }

        /// <summary>
        /// Adds authentication service
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        public static void AddSmiAuthentication(this IServiceCollection services)
        {
            //set default authentication schemes
            var authenticationBuilder = services.AddAuthentication(options =>
            {
                options.DefaultChallengeScheme = SmiAuthenticationDefaults.AuthenticationScheme;
                options.DefaultScheme = SmiAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = SmiAuthenticationDefaults.ExternalAuthenticationScheme;
            });

            //add main cookie authentication
            authenticationBuilder.AddCookie(SmiAuthenticationDefaults.AuthenticationScheme, options =>
            {
                options.Cookie.Name = $"{SmiCookieDefaults.Prefix}{SmiCookieDefaults.AuthenticationCookie}";
                options.Cookie.HttpOnly = true;
                options.LoginPath = SmiAuthenticationDefaults.LoginPath;
                options.AccessDeniedPath = SmiAuthenticationDefaults.AccessDeniedPath;

                //whether to allow the use of authentication cookies from SSL protected page on the other store pages which are not
                options.Cookie.SecurePolicy = DataSettingsManager.DatabaseIsInstalled && EngineContext.Current.Resolve<IStoreContext>().CurrentStore.SslEnabled
                    ? CookieSecurePolicy.SameAsRequest : CookieSecurePolicy.None;
            });

            //add external authentication
            authenticationBuilder.AddCookie(SmiAuthenticationDefaults.ExternalAuthenticationScheme, options =>
            {
                options.Cookie.Name = $"{SmiCookieDefaults.Prefix}{SmiCookieDefaults.ExternalAuthenticationCookie}";
                options.Cookie.HttpOnly = true;
                options.LoginPath = SmiAuthenticationDefaults.LoginPath;
                options.AccessDeniedPath = SmiAuthenticationDefaults.AccessDeniedPath;

                //whether to allow the use of authentication cookies from SSL protected page on the other store pages which are not
                options.Cookie.SecurePolicy = DataSettingsManager.DatabaseIsInstalled && EngineContext.Current.Resolve<IStoreContext>().CurrentStore.SslEnabled
                    ? CookieSecurePolicy.SameAsRequest : CookieSecurePolicy.None;
            });

            //register and configure external authentication plugins now
            var typeFinder = new WebAppTypeFinder();
            var externalAuthConfigurations = typeFinder.FindClassesOfType<IExternalAuthenticationRegistrar>();
            var externalAuthInstances = externalAuthConfigurations
                .Select(x => (IExternalAuthenticationRegistrar)Activator.CreateInstance(x));

            foreach (var instance in externalAuthInstances)
                instance.Configure(authenticationBuilder);
        }

        /// <summary>
        /// Add and configure MVC for the application
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        /// <returns>A builder for configuring MVC services</returns>
        public static IMvcBuilder AddSmiMvc(this IServiceCollection services)
        {
            //add basic MVC feature
            var mvcBuilder = services.AddControllersWithViews();

            mvcBuilder.AddRazorRuntimeCompilation();

            var SmiConfig = services.BuildServiceProvider().GetRequiredService<SmiConfig>();
            if (SmiConfig.UseSessionStateTempDataProvider)
            {
                //use session-based temp data provider
                mvcBuilder.AddSessionStateTempDataProvider();
            }
            else
            {
                //use cookie-based temp data provider
                mvcBuilder.AddCookieTempDataProvider(options =>
                {
                    options.Cookie.Name = $"{SmiCookieDefaults.Prefix}{SmiCookieDefaults.TempDataCookie}";

                    //whether to allow the use of cookies from SSL protected page on the other store pages which are not
                    options.Cookie.SecurePolicy = DataSettingsManager.DatabaseIsInstalled && EngineContext.Current.Resolve<IStoreContext>().CurrentStore.SslEnabled
                        ? CookieSecurePolicy.SameAsRequest : CookieSecurePolicy.None;
                });
            }

            services.AddRazorPages();

            //MVC now serializes JSON with camel case names by default, use this code to avoid it
            mvcBuilder.AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());

            //add custom display metadata provider
            mvcBuilder.AddMvcOptions(options => options.ModelMetadataDetailsProviders.Add(new SmiMetadataProvider()));

            //add custom model binder provider (to the top of the provider list)
            mvcBuilder.AddMvcOptions(options => options.ModelBinderProviders.Insert(0, new SmiModelBinderProvider()));

            //add fluent validation
            mvcBuilder.AddFluentValidation(configuration =>
            {
                //register all available validators from Smi assemblies
                var assemblies = mvcBuilder.PartManager.ApplicationParts
                    .OfType<AssemblyPart>()
                    .Where(part => part.Name.StartsWith("Smi", StringComparison.InvariantCultureIgnoreCase))
                    .Select(part => part.Assembly);
                configuration.RegisterValidatorsFromAssemblies(assemblies);

                //implicit/automatic validation of child properties
                configuration.ImplicitlyValidateChildProperties = true;
            });

            //register controllers as services, it'll allow to override them
            mvcBuilder.AddControllersAsServices();

            return mvcBuilder;
        }

        /// <summary>
        /// Register custom RedirectResultExecutor
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        public static void AddSmiRedirectResultExecutor(this IServiceCollection services)
        {
            //we use custom redirect executor as a workaround to allow using non-ASCII characters in redirect URLs
            services.AddSingleton<IActionResultExecutor<RedirectResult>, SmiRedirectResultExecutor>();
        }

        /// <summary>
        /// Add and configure MiniProfiler service
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        public static void AddSmiMiniProfiler(this IServiceCollection services)
        {
            //whether database is already installed
            if (!DataSettingsManager.DatabaseIsInstalled)
                return;

            services.AddMiniProfiler(miniProfilerOptions =>
            {
                //use memory cache provider for storing each result
                ((MemoryCacheStorage)miniProfilerOptions.Storage).CacheDuration = TimeSpan.FromMinutes(60);

                //whether MiniProfiler should be displayed
                miniProfilerOptions.ShouldProfile = request =>
                    EngineContext.Current.Resolve<StoreInformationSettings>().DisplayMiniProfilerInPublicStore;

                //determine who can access the MiniProfiler results
                miniProfilerOptions.ResultsAuthorize = request =>
                    !EngineContext.Current.Resolve<StoreInformationSettings>().DisplayMiniProfilerForAdminOnly ||
                    EngineContext.Current.Resolve<IPermissionService>().Authorize(StandardPermissionProvider.AccessAdminPanel);
            });
        }

        /// <summary>
        /// Add and configure WebMarkupMin service
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        public static void AddSmiWebMarkupMin(this IServiceCollection services)
        {
            //check whether database is installed
            if (!DataSettingsManager.DatabaseIsInstalled)
                return;

            services
                .AddWebMarkupMin(options =>
                {
                    options.AllowMinificationInDevelopmentEnvironment = true;
                    options.AllowCompressionInDevelopmentEnvironment = true;
                    options.DisableMinification = !EngineContext.Current.Resolve<CommonSettings>().EnableHtmlMinification;
                    options.DisableCompression = true;
                    options.DisablePoweredByHttpHeaders = true;
                })
                .AddHtmlMinification(options =>
                {
                    options.CssMinifierFactory = new NUglifyCssMinifierFactory();
                    options.JsMinifierFactory = new NUglifyJsMinifierFactory();
                })
                .AddXmlMinification(options =>
                {
                    var settings = options.MinificationSettings;
                    settings.RenderEmptyTagsWithSpace = true;
                    settings.CollapseTagsWithoutContent = true;
                });
        }

        /// <summary>
        /// Add and configure default HTTP clients
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        public static void AddSmiHttpClients(this IServiceCollection services)
        {
            //default client
            services.AddHttpClient(SmiHttpDefaults.DefaultHttpClient).WithProxy();

            //client to request current store
            services.AddHttpClient<StoreHttpClient>();

            //client to request SmiMarketplace official site
            services.AddHttpClient<SmiHttpClient>().WithProxy();

            //client to request reCAPTCHA service
            services.AddHttpClient<CaptchaHttpClient>().WithProxy();
        }
    }
}