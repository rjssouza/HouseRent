using Autofac;
using Autofac.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.OpenApi.Models;
using Module.Dto.Config;
using Module.IoC.Interface;
using Module.IoC.Register;
using Module.Util.Json;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Reflection;
using WebApi.Base;
using WebApi.Filter;

namespace WebApi
{
    /// <summary>
    /// Classe de inicializa��o da api
    /// </summary>
    public class Startup : IControllerRegister
    {
        private SettingsDto _settings;

        /// <summary>
        /// Construtor de ambiente
        /// </summary>
        /// <param name="env">Ambiente</param>
        public Startup(IWebHostEnvironment env)
        {
#if DEBUG
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
#elif PRODUCTION
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.Production.json", optional: true)
                .AddEnvironmentVariables();
#elif RELEASE
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.Release.json", optional: true)
                .AddEnvironmentVariables();
#endif
            this.Configuration = builder.Build();
        }

        /// <summary>
        /// Container Autofac
        /// </summary>
        public ILifetimeScope AutofacContainer { get; private set; }

        /// <summary>
        /// Objeto de configura��es
        /// </summary>
        public SettingsDto Settings => this._settings;

        /// <summary>
        /// Servi�o para acesso de configura��es appsettings.json
        /// </summary>
        public IConfigurationRoot Configuration { get; private set; }

        /// <summary>
        /// Acessador de contexto
        /// </summary>
        public HttpContextAccessor HttpContextAccessor => new();

        /// <summary>
        /// M�todo para configurar aplica��o
        /// </summary>
        /// <param name="app">Servi�o de construtor da aplica��o</param>
        /// <param name="env">Servi�o de ambiente da aplica��o</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(x => x
               .AllowAnyMethod()
               .AllowAnyHeader()
               .SetIsOriginAllowed(origin => true) // allow any origin
               .AllowCredentials()); // allow credentials

            //app.UseAuthorization();

            //app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger(c =>
            {
                c.SerializeAsV2 = true;
            });

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Loca��o Im�veis API V1");
                c.RoutePrefix = string.Empty;
            });
        }

        /// <summary>
        /// Chamada da implementa��o para configurar container (chamada efetuada pelo m�dulo Module.Ioc)
        /// </summary>
        /// <param name="builder">Container builder autofac</param>
        public void ConfigureContainer(ContainerBuilder builder)
        {
            Register.RegisterDependencyInjection(builder, this);
        }

        /// <summary>
        /// M�todo para registrar servi�os .net core
        /// </summary>
        /// <param name="services">Registrador de servi�os</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();

            services.AddControllers();

            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(ExceptionFilter));
            })
            .AddControllersAsServices()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
                options.JsonSerializerOptions.Converters.Add(new JsonConverterByteArrayGlobal());
            });

            services.AddHttpContextAccessor();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "ToDo API",
                    Description = "A simple example ASP.NET Core Web API",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Shayne Boyer",
                        Email = string.Empty,
                        Url = new Uri("https://twitter.com/spboyer"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under LICX",
                        Url = new Uri("https://example.com/license"),
                    }
                });

                string applicationBasePath =
                    PlatformServices.Default.Application.ApplicationBasePath;
                string applicationName =
                    PlatformServices.Default.Application.ApplicationName;
                string caminhoXmlDoc =
                    Path.Combine(applicationBasePath, $"{applicationName}.xml");

                c.IncludeXmlComments(caminhoXmlDoc);
            });

            this.RegisterSettings();

            ConfigureAuthentication(services);
        }

        /// <summary>
        /// M�todo para a��es customizadas ao ativar um tipo j� cadastrado na inje��o de dependencia (caso necess�rio)
        /// </summary>
        /// <typeparam name="TypeOf">Tipo</typeparam>
        /// <param name="e">Tipo que est� sendo instanciado</param>
        public void OnActivatingInstance<TypeOf>(IActivatingEventArgs<TypeOf> e)
        {
        }

        /// <summary>
        /// Registro de controllers
        /// </summary>
        /// <param name="builder">Container builder autofac</param>
        public void RegisterInternalComponents(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load(typeof(ServiceController).Assembly.GetName()))
                   .PropertiesAutowired();
        }

        /// <summary>
        /// Registro das configura��es do sistema
        /// </summary>
        private void RegisterSettings()
        {
            var externalServicesApiUrl = this.Configuration.GetSection("ApiServicesUrl");
            var dbConnection = this.Configuration.GetSection("DbConnection");

            this._settings = new SettingsDto()
            {
                ApiServicesUrl = new ExternalApiSettingsDto()
                {
                    ViaCepApiUrl = externalServicesApiUrl.GetValue<string>("ViaCepApiUrl")
                },
                DbConnection = new DbSettingsDto()
                {
                    Default = dbConnection.GetValue<string>("Default")
                }
            };
        }

        /// <summary>
        /// Configura��o da autoridade de autentica��o
        /// </summary>
        /// <param name="services">Service Collection .Net Core</param>
        private static void ConfigureAuthentication(IServiceCollection services)
        {
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
        }
    }
}