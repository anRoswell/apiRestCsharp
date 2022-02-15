using Core.CustomEntities;
using Core.Interfaces;
using Core.ModelProcess;
using Core.Services;
using Infrastructure.Data;
using Infrastructure.Interfaces;
using Infrastructure.Options;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;

namespace Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            // Configuracion para la conexion a la Base de Datos
            services.AddDbContext<DbModelContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("PortalProveedoresEntities"));
            }, ServiceLifetime.Transient);

            //services.AddDbContext<DbModelContext>(options =>
            //{
            //    options.UseSqlServer(configuration.GetConnectionString("PortalProveedoresEntitiesDev"));
            //}, ServiceLifetime.Transient);

            return services;
        }

        public static IServiceCollection AddOptions(this IServiceCollection services, IConfiguration configuration)
        {
            // Configuraciones de Paginacion y Password
            services.Configure<PaginationOptions>(options => configuration.GetSection("Pagination").Bind(options));
            services.Configure<PasswordOptions>(options => configuration.GetSection("PasswordOptions").Bind(options));

            // Configuracion para definir si el ApiController controla las validaciones de ModelState
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            // Inyección de Depencias
            /* Suponiendo que cambiamos de motor de Base de Datos, este proceso nos facilita que 
             * no nos toque reestructurar el proyecto para acoplarlo a cada motor de Base de datos.
             */
            services.AddTransient<IFilesProcess, FilesProcess>();
            services.AddTransient<IMenuService, MenuService>();
            services.AddTransient<IParametrosInicialesService, ParametrosInicialesService>();
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<IPerfilService, PerfilService>();
            services.AddTransient<IPerfilesXusuarioService, PerfilesXusuarioService>();
            services.AddTransient<IPermisosEmpresasxUsuarioService, PermisosEmpresasXUsuarioService>();
            services.AddTransient<IPermisosMenuXPerfilService, PermisosMenuXPerfilService>();
            services.AddTransient<IPermisosUsuarioxMenuService, PermisosUsuarioxMenuService>();

            services.AddTransient<IRefererServidoresService, RefererServidoresService>();
            services.AddTransient<IPeticionesCorsService, PeticionesCorsService>();

            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<IPasswordService, PasswordService>();
            services.AddSingleton<IUriService>(provider =>
            {
                var accesor = provider.GetRequiredService<IHttpContextAccessor>();
                var request = accesor.HttpContext.Request;
                var absoluteUri = string.Concat(request.Scheme, "://", request.Host.ToUriComponent());
                return new UriService(absoluteUri);
            });

            return services;
        }

        public static IServiceCollection AddSwagger(this IServiceCollection services, IConfiguration configuration, string xmlFileName)
        {
            // Configuracion Swagger
            services.AddSwaggerGen(doc =>
            {
                doc.SwaggerDoc(configuration["Swagger:Version"], new OpenApiInfo
                {
                    Title = configuration["Swagger:Title"],
                    Version = configuration["Swagger:Version"]
                });

                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFileName);
                doc.IncludeXmlComments(xmlPath);

                doc.AddSecurityDefinition(configuration["Swagger:SecurityName"], new OpenApiSecurityScheme
                {
                    Description = configuration["Swagger:DescriptionToken"],
                    Name = configuration["Swagger:HeaderName"],
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                });

                doc.AddSecurityRequirement(new OpenApiSecurityRequirement {
                   {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] { }
                   }
                });
            });

            return services;
        }

        public static IServiceCollection AddCorsApp(this IServiceCollection services)
        {
            // Configuracion CORS
            services.AddCors(options =>
            {
                options.AddPolicy("ApiCors", builder =>
                {
                    builder
                    .AllowAnyOrigin()
                    // Esto no va en produccion, sólo local
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .WithExposedHeaders("Authorization"); // Expone el token para que las Apps lo puedan ver
                    // .AllowCredentials()
                });
            });

            return services;
        }
    }
}
