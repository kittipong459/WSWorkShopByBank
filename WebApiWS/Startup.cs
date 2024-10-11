using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using WebApiSTD.Class;
using WebApiSTD.Models.Setting;

namespace WebApiWS
{
    public class Startup
    {

        string tC_AppName;
        string tC_AppVer;
        string tC_RunTimeVer;

        public Startup(IConfiguration configuration)
        {
            try
            {
                //*Config STD
                Configuration = configuration;

                //Read Config
                cVB.oVB_AppSettings = new cmlAppSettings();
                cVB.oVB_MQSettings = new cmlRabbitMQSettings();
                cVB.oVB_DBSettings = new cmlDBSettings();
                Configuration.GetSection("AppSettings").Bind(cVB.oVB_AppSettings);
                Configuration.GetSection("RabbitMQSettings").Bind(cVB.oVB_MQSettings);
                Configuration.GetSection("ConnectionStrings").Bind(cVB.oVB_DBSettings);

                tC_AppName = Assembly.GetExecutingAssembly().GetName().Name;  //Application Name
                tC_AppVer = Assembly.GetEntryAssembly().GetName().Version.ToString();  //Application Version
                tC_RunTimeVer = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;  //Runtime Version
                                                                                                         //+++++++++++++
            }
            catch (Exception)
            {
            }
            finally
            {

            }
        }


        public static IConfiguration Configuration { get; set; } //*Config STD

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            try
            {
                //*Config STD
                services.AddControllers();
                const string tReqHeaders = "X-Api-Key";
                services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1", new OpenApiInfo { Title = $"{tC_AppName} V{tC_AppVer}", Version = $"{tC_RunTimeVer}" });
                    c.AddSecurityDefinition(tReqHeaders, new OpenApiSecurityScheme
                    {
                        Description = "Api key needed to access the endpoints. X-Api-Key: My_API_Key",
                        In = ParameterLocation.Header,
                        Name = tReqHeaders,
                        Type = SecuritySchemeType.ApiKey
                    });

                    c.AddSecurityRequirement(new OpenApiSecurityRequirement
                    {
                    {
                        new OpenApiSecurityScheme
                        {
                            Name = tReqHeaders,
                            Type = SecuritySchemeType.ApiKey,
                            In = ParameterLocation.Header,
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = tReqHeaders
                            },
                         },
                         new string[] {}
                     }
                    });
                });
                //+++++++++++++
            }
            catch (Exception)
            {

            }
            finally
            {

            }
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            try
            {
                //*Config STD
                app.UseRouting();
                app.UseAuthorization();
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}");
                });

                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint($"/swagger/v1/swagger.json", $"{tC_AppName} V{tC_AppVer}");
                });
                //+++++++++++++
            }
            catch (Exception)
            {
            }
            finally
            {

            }
        }
    }
}
