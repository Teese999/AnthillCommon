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
        //osipenkom: async метод без асинхронного вызова внутри не имеет смысла.
        public async void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
                .AddJsonOptions(x => x.JsonSerializerOptions.IgnoreNullValues = true)
                .AddControllersAsServices()
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);

            services.AddHttpContextAccessor();
            services.AddControllers();

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

            //osipenkom: все автомапперы можно зарегестрировать в DI здесь таким образом. тогда не нужна будет ни фабрика, ни интерфейс автомаппера - всё очень упрощается.
            services.AddAutoMapper(typeof(CityMapperProfile));
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

        //osipenkom: неиспользуемый метод. по конвенции назван неправильно. названия переменных внутри неправильные.
        private async void commonDbCreaTE()
        {
            var cont = new CommonContext();
            var qq = new OrganisationRepository(cont);
            var z = new CityRepository(cont);
            var a = new OfficeRepository(cont);
            var u = new UserRepository(cont);
            var i = 0;
            foreach (var item in a.GetAll().Result)
            {

                await u.Add(new User()
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
            //    await z.Add(new City()
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
        }
    }
}
