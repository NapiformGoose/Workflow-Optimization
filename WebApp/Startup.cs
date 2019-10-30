using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Interfaces;
using Logics;
using Storage;
using System.Reflection;

namespace WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        readonly string AllowAllOrigin = "AllowAllOrigin";

        public void ConfigureServices(IServiceCollection services)
        {
            var assembly = Assembly.Load("WebView");

            //services.AddTransient<WorkflowOpimizationDBContext, WorkflowOpimizationDBContext>();
            //services.AddDbContext<WorkflowOpimizationDBContext>(options => options.UseSqlServer(Configuration["database:connection"]));
            services.AddMvc().AddApplicationPart(assembly).AddControllersAsServices();


            services.AddDbContext<WorkflowOpimizationDBContext>(options => options.UseSqlServer("Data Source=DEV06\\SQLEXPRESS;Initial Catalog=WorkflowOptimizationDB;Integrated Security=True"));
            services.AddTransient<IMaterialService, MaterialService>();
            services.AddTransient<IStorageContext, WorkflowOpimizationDBContext>();
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigin",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyMethod()
                               .AllowAnyHeader();
                    });
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors(AllowAllOrigin);
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
