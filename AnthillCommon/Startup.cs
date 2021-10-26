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

            ///JWT
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                    .AddJwtBearer(options =>
                    {
                        var settingsSection = Configuration.GetSection("Settings");
                        services.Configure<Settings>(settingsSection);
                        var settings = settingsSection.Get<Settings>();

                        options.RequireHttpsMetadata = false;
                        options.TokenValidationParameters = new TokenValidationParameters
                        {
                            
                            ValidateIssuerSigningKey = true,
                            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(settings.KEY)),
                            ValidateIssuer = false,
                            ValidateAudience = false,
                           
                            ClockSkew = TimeSpan.Zero
                        };
                    });
            services.AddControllersWithViews();

            services.AddAuthorization();

            services.AddAutoMapper(new Type[] { typeof(CityMapperProfile), typeof(UserMapperProfile), typeof(OfficeMapperProfile), typeof(OrganizationMapperProfile) } );
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

        private async void CommonDbCreate()
        {
            var cont = new CommonContext();
            var organisation = new OrganizationRepository(cont);
            var city = new CityRepository(cont);
            var office = new OfficeRepository(cont);
            var user = new UserRepository(cont);
            var i = 0;
            foreach (var item in await office.GetAll())
            {

                await user.Add(new User()
                {
                    FirstName = $"FirstName_{i}",
                    LastName = $"LastName_{i}",
                    Email = $"Mail_{i}",
                    BirthDate = DateTime.Today,
                    Gender = $"RandomGender_{i}",
                    CreateDate = DateTime.Now,
                    UpdateTime = DateTime.Now,
                    IsFired = false,
                    Office = item
                });
                i++;
            }
            //for (int i = 0; i < 10; i++)
            //{
            //    await city.Add(new City()
            //    {
            //        Name = $"City_{i}",
            //        State = $"State_{i}",
            //        Country = $"Country_{i}",
            //        CreateDate = DateTime.Now,
            //        UpdateTime = DateTime.Now
            //    });
            //}
            //Id = i,
            //        FirstName = $"FirstName_{i}",
            //        LastName = $"LastName_{i}",
            //        Email = $"Mail_{i}",
            //        BirthDate = DateTime.Today,
            //        Gender = $"RandomGender_{i}",
            //        CreateDate = DateTime.Now,
            //        UpdateTime = DateTime.Now,
            //        IsFired = false,
            //for (int i = 0; i < 10; i++)
            //{
            //    await organisation.Add( new Organization()
            //    {
            //        Name = $"Organisation_{i}",
            //        CreateDate = DateTime.Now,
            //        UpdateTime = DateTime.Now
            //    });
            //}
            //for (int i = 1; i < 11; i++)
            //{
            //    await office.Add(new Office()
            //    {
            //        Name = $"Office_{i}",
            //        Address = $"Address_{i}",
            //        CreateDate = DateTime.Now,
            //        UpdateTime = DateTime.Now,
            //        Organization = await organisation.GetByKey(i),
            //        City = await city.GetByKey(i),
            //    });
            //}
        }
    }
}
