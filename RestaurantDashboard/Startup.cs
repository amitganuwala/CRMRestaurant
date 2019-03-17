using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CRM.Core.Infrastructure;
using CRM.Data;
using CRM.Data.Interfaces;
using CRM.Services.ProductTypes;
using CRM.Services.Products;
using CRM.Services.Addons;
using CRM.Services.Options;
using CRM.Services.Gallerys;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using RestaurantDashboard.Data;
using RestaurantDashboard.Utils;

namespace RestaurantDashboard
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddDbContext<dbContextCRM>(options =>
          options.UseLazyLoadingProxies().UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //    .AddDbContext<BloggingContext>(
            //b => b.UseLazyLoadingProxies()
            //      .UseSqlServer(myConnectionString));

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddMvc().AddSessionStateTempDataProvider();
            services.AddSession();


            AddAutoMapper(services);
            services.AddTransient(typeof(IRepository<>), typeof(EfRepository<>));
            services.AddTransient(typeof(IAsyncRepository<>), typeof(EfRepository<>));

            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.TryAddSingleton<HttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IProductTypeServices, ProductTypeServices>();
            services.AddScoped<IAddonServices, AddonServices>();
            services.AddScoped<IOptionServices, OptionServices>();
            services.AddScoped<IProductServices, ProductServices>();
            services.AddScoped<IGalleryServices, GalleryServices>();
        }


        protected virtual void AddAutoMapper(IServiceCollection services)
        {
            //create and sort instances of mapper configurations

            //create AutoMapper configuration
            var mappingProfile = new AdminMapperConfiguration();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(mappingProfile);
            });

            //register AutoMapper
            services.AddAutoMapper();

            //register
            AutoMapperConfiguration.Init(config);
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseCookiePolicy();

            app.UseAuthentication();
            app.UseSession();
            //app.UseMvcWithDefaultRoute();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                     //template: "{controller=Home}/{action=Login}/{id?}");
                       template: "{controller=Dashboard}/{action=index}/{id?}");
            });
            
        }
    }
}
