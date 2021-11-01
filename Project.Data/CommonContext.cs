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
        private readonly Random _rnd = new Random();
        public string ConnectionString { get; private set; }
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
            for (int i = 0; i < 5; i++)
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
            for (int i = 0; i < 5; i++)
            {
                organizations.Add(new Organization()
                {
                    Id = i + 1,
                    Name = $"Organisation_{i+1}",
                    CreateDate = DateTime.Now,
                    UpdateTime = DateTime.Now
                });
            }
            int id = 1;
            for (int i = 0; i < 5; i++)
            {

                offices.Add(new Office()
                {
                    Id = id,
                    Name = $"Office_{id}",
                    Address = $"Address_{id}",
                    CreateDate = DateTime.Now,
                    UpdateTime = DateTime.Now,
                    CityId = cities[i].Id,
                    OrganizationId = organizations[i].Id,
                });
                id++;
                offices.Add(new Office()
                {
                    Id = id,
                    Name = $"Office_{id}",
                    Address = $"Address_{id}",
                    CreateDate = DateTime.Now,
                    UpdateTime = DateTime.Now,
                    CityId = cities[i].Id,
                    OrganizationId = organizations[i].Id,
                });
                id++;
            }
            for (int i = 0; i < 100; i++)
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
                    OfficeId = offices[_rnd.Next(offices.Count)].Id,
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
                ConnectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
                
            }
        }
    }

    
}
