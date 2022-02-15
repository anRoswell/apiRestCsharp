using Api.Responses;
using FluentValidation.AspNetCore;
using Infrastructure.Extensions;
using Infrastructure.Filters;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Configuracion para implementar AutoMapper
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddControllers(options =>
            {
                options.Filters.Add<GlobalExceptionFilter>();
                options.Filters.Add<SoportarCorsAttribute>();
                options.Filters.Add<ValidationFilter>();
            })
            .AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            })
            .ConfigureApiBehaviorOptions(options =>
            {
                //options.SuppressModelStateInvalidFilter = true;
            });

            // Configuracion de opciones
            services.AddOptions(Configuration);

            // Configuracion para la conexion a la Base de Datos
            services.AddDbContexts(Configuration);

            // Inyeccion de Dependencias
            services.AddServices();

            services.AddSwagger(Configuration, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml");

            // Configuracion para controlar CORS
            services.AddCorsApp();

            // Configuracion para la Autenticacion (JWT)
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true, // Validar el Emisor
                    ValidateAudience = true, // Vaidar la audiencia
                    ValidateLifetime = true, // Validar el tiempo de vida del token
                    ValidateIssuerSigningKey = true, // Validar la firma del emisor
                    ValidIssuer = Configuration["Authentication:Issuer"],
                    ValidAudience = Configuration["Authentication:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Authentication:SecretKey"]))
                };
                options.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = (context) =>
                    {
                        if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                        {
                            context.HttpContext.Items.Add("TipoError","Expired");
                        }
                        else
                        {
                            context.HttpContext.Items.Add("TipoError", "Invalid");
                        }

                        return Task.CompletedTask;
                    },
                    OnChallenge = async (context) =>
                    {
                        // this is a default method
                        // the response statusCode and headers are set here
                        context.HandleResponse();

                        // AuthenticateFailure property contains 
                        // the details about why the authentication has failed
                        if (context.AuthenticateFailure != null)
                        {
                            if (context.HttpContext.Items.ContainsKey("TipoError"))
                            {
                                string error = "";
                                int codigoResponse = 401;

                                string tipoError = context.HttpContext.Items["TipoError"].ToString();

                                // AuthenticateFailure property contains 
                                // the details about why the authentication has failed
                                if (tipoError.Equals("Expired"))
                                {
                                    error = "La sesión del usuario está vencida, por favor ingrese de nuevo al sistema";
                                    codigoResponse = (int)HttpStatusCode.Forbidden;
                                }
                                else if (tipoError.Equals("Invalid"))
                                {
                                    error = "La autenticación del usuario es inválida";
                                    codigoResponse = (int)HttpStatusCode.Unauthorized;
                                }

                                // Write to the response in any way you wish
                                context.Response.StatusCode = codigoResponse;
                                context.Response.Headers.Append("WWW-Authenticate", $"Bearer error='{context.Error}'");

                                // we can write our own custom response content here
                                var response = ErrorResponse.GetErrorDescripcion(false, error, context.ErrorDescription, codigoResponse);
                                await context.Response.WriteAsJsonAsync(response);
                            }
                            else
                            {
                                // Write to the response in any way you wish
                                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                                context.Response.Headers.Append("WWW-Authenticate", $"Bearer error='{context.Error}'");

                                // we can write our own custom response content here
                                var response = ErrorResponse.GetErrorDescripcion(false, "La autenticación del usuario es inválida", context.ErrorDescription, 401);
                                await context.Response.WriteAsJsonAsync(response);
                            }                            
                        }
                    }
                };
            });

            // Configuracion para controlar Filtros del Request y las Validaciones de las entidades
            services.AddMvc(options =>
            {

            })
            .AddFluentValidation(options =>
            {
                options.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Habilitamos los CORS
            app.UseCors("ApiCors");

            app.UseHttpsRedirection();

            // Configuracion Swagger
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint(Configuration["Swagger:Url"], Configuration["Swagger:DefinitionName"]);
                options.RoutePrefix = string.Empty;

                options.DocumentTitle = Configuration["Swagger:DocumentTitle"];
                options.DocExpansion(DocExpansion.List);
            });

            app.UseRouting();

            // Configuracion JWT
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
