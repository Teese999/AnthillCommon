using AnthillCommon.DataContext;
using AnthillCommon.Models;
using AnthillCommon.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

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
        public async void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
                .AddJsonOptions(x => x.JsonSerializerOptions.IgnoreNullValues = true)
                .AddControllersAsServices()
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);

            services.AddHttpContextAccessor();
            services.AddControllers();

            
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
