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

using CRM.Data;
using CRM.Services;
using CRM.Core.Domain.Products;
using CRM.Core.Domain.Addons;
using CRM.Core.Infrastructure;
using CRM.Services.Addons;
using CRM.Data.Interfaces;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using ApiForRestaurentDashboard.Helpers;
using System.Text;
using ApiForRestaurentDashboard.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CRM.Services.Registrations;


namespace ApiForRestaurentDashboard
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


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);


            services.Configure<ApiBehaviorOptions>(Options => {

                Options.SuppressConsumesConstraintForFormFileParameters = true;
                Options.SuppressInferBindingSourcesForParameters = true;
                Options.SuppressModelStateInvalidFilter = true;

            });




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


            // configure strongly typed settings objects
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            // configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });


            //Newton json
            services.AddMvc()
    .AddJsonOptions(
        options => options.SerializerSettings.ReferenceLoopHandling =
        Newtonsoft.Json.ReferenceLoopHandling.Ignore
    );
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            AddAutoMapper(services);
            services.AddTransient(typeof(IRepository<>), typeof(EfRepository<>));
            services.AddTransient(typeof(IAsyncRepository<>), typeof(EfRepository<>));
            //services.AddScoped<ITaxCategoryService, TaxCategoryService>();


            services.AddScoped<IAddonServices, AddonServices>();
            services.AddScoped<IRegistrationServices, RegistrationServices>();

           
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
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        protected virtual void AddAutoMapper(IServiceCollection services)
        {

        }

    }
}
