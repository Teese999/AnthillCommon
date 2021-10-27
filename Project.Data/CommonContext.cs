using AnthillCommon.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Unity;
using System.IO;
using AnthillCommon.Models;
using Project.Data.Models;

namespace AnthillCommon.DataContext
{
    public class CommonContext : DbContext
    {
        public CommonContext() : base()
        {
        }
        public CommonContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new OrganizationMap());
            modelBuilder.ApplyConfiguration(new OfficeMap());
            modelBuilder.ApplyConfiguration(new CityMap());
            modelBuilder.ApplyConfiguration(new AccountMap());


            var users = new List<User>();
            var organizations = new List<Organization>();
            var offices = new List<Office>();
            var cities = new List<City>();
            for (int i = 0; i < 10; i++)
            {
                cities.Add(new City()
                {
                    Id = i+1,
                    Name = $"City_{i+1}",
                    State = $"State_{i+1}",
                    Country = $"Country_{i+1}",
                    CreateDate = DateTime.Now,
                    UpdateTime = DateTime.Now
                });
            }
            for (int i = 0; i < 10; i++)
            {
                organizations.Add(new Organization()
                {
                    Id = i + 1,
                    Name = $"Organisation_{i+1}",
                    CreateDate = DateTime.Now,
                    UpdateTime = DateTime.Now
                });
            }
            for (int i = 0; i < 10; i++)
            {

                offices.Add(new Office()
                {
                    Id = i + 1,
                    Name = $"Office_{i+1}",
                    Address = $"Address_{i+1}",
                    CreateDate = DateTime.Now,
                    UpdateTime = DateTime.Now,
                    CityId = cities[i].Id,
                    OrganizationId = organizations[i].Id,
                });

            }
            for (int i = 0; i < 10; i++)
            {

                users.Add(new User()
                {
                    Id = i + 1,
                    FirstName = $"FirstName_{i}",
                    LastName = $"LastName_{i}",
                    Email = $"Mail_{i}",
                    BirthDate = DateTime.Today,
                    Gender = $"RandomGender_{i}",
                    CreateDate = DateTime.Now,
                    UpdateTime = DateTime.Now,
                    IsFired = false,
                    OfficeId = offices[i].Id,
                });

            }
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Organization>().HasData(organizations);
            modelBuilder.Entity<Office>().HasData(offices);
            modelBuilder.Entity<City>().HasData(cities);
        }
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            var configuration = builder.Build();

            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
        }
    }

    
}
