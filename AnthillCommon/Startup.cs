using AnthillCommon.DataContext;
using AnthillCommon.Models;
using AnthillCommon.Repositories;
using AnthillCommon.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Identity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;
using AnthillCommon.Services.Mappers;
using AnthilCommon.Common.Services;
using AnthillCommon.Mappings;
using Microsoft.EntityFrameworkCore;
using AnthillCommon.Services.ValidationFilters;
using AnthillComon.Common.Enums;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AnthillCommon
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
            services.AddControllers()
                .AddJsonOptions(x => x.JsonSerializerOptions.IgnoreNullValues = true)
                .AddControllersAsServices()
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);

            services.AddHttpContextAccessor();

            //Settings download
            var settingsSection = Configuration.GetSection("Settings");
            services.Configure<Settings>(settingsSection);
            var settings = settingsSection.Get<Settings>();


            var tokenValidationParams = new TokenValidationParameters
            {

                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(settings.KEY)),
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = false,
                RequireExpirationTime = false,
                ClockSkew = TimeSpan.Zero
            };

            services.AddSingleton(tokenValidationParams);


            ///JWT
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                    .AddJwtBearer(options =>
                    {

                        options.SaveToken = true;
                        options.RequireHttpsMetadata = false;
                        options.TokenValidationParameters = tokenValidationParams;
                    });
            services.AddControllersWithViews();

            services.AddAuthorization();

            services.AddControllers().AddNewtonsoftJson();

            services.AddAutoMapper(new Type[] { 
                typeof(CityMapperProfile),
                typeof(UserMapperProfile),
                typeof(OfficeMapperProfile),
                typeof(OrganizationMapperProfile),
                typeof(SubscriptionMapperProfile),
                typeof(AccountMapperProfile),
                typeof(PaginationModel),
                typeof(SubscriptionMapperProfile)
            });
            services.AddAutoMapper(new Type[] { typeof(CityModelMapper), typeof(UserModelMapper), typeof(OfficeModelMapper), typeof(OrganizationModelMapper) });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();


            });
            
        }

        public void ConfigureContainer(IUnityContainer container)
        {
            // Could be used to register more types
            ContainerConfiguration.RegisterTypes<HierarchicalLifetimeManager>(container, Configuration);
        }

       
        
    }
}
