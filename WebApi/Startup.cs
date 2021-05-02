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
    /// Classe de inicialização da api
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
        /// Objeto de configurações
        /// </summary>
        public SettingsDto Settings => this._settings;

        /// <summary>
        /// Serviço para acesso de configurações appsettings.json
        /// </summary>
        public IConfigurationRoot Configuration { get; private set; }

        /// <summary>
        /// Acessador de contexto
        /// </summary>
        public HttpContextAccessor HttpContextAccessor => new();

        /// <summary>
        /// Método para configurar aplicação
        /// </summary>
        /// <param name="app">Serviço de construtor da aplicação</param>
        /// <param name="env">Serviço de ambiente da aplicação</param>
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
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Locação Imóveis API V1");
                c.RoutePrefix = string.Empty;
            });
        }

        /// <summary>
        /// Chamada da implementação para configurar container (chamada efetuada pelo módulo Module.Ioc)
        /// </summary>
        /// <param name="builder">Container builder autofac</param>
        public void ConfigureContainer(ContainerBuilder builder)
        {
            Register.RegisterDependencyInjection(builder, this);
        }

        /// <summary>
        /// Método para registrar serviços .net core
        /// </summary>
        /// <param name="services">Registrador de serviços</param>
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
        /// Método para ações customizadas ao ativar um tipo já cadastrado na injeção de dependencia (caso necessário)
        /// </summary>
        /// <typeparam name="TypeOf">Tipo</typeparam>
        /// <param name="e">Tipo que está sendo instanciado</param>
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
        /// Registro das configurações do sistema
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
        /// Configuração da autoridade de autenticação
        /// </summary>
        /// <param name="services">Service Collection .Net Core</param>
        private static void ConfigureAuthentication(IServiceCollection services)
        {
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
        }
    }
}