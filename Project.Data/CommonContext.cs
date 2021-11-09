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
using AnthillComon.Common.Enums;

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
            modelBuilder.ApplyConfiguration(new RefreshtokenMap());
            modelBuilder.ApplyConfiguration(new SubscriptionMap());
            modelBuilder.ApplyConfiguration(new SubscriptionVersionMap());
            


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
            for (int i = 0; i < 3; i++)
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
            foreach (var item in organizations)
            {
                for (int i = 0; i < 2; i++)
                {
                    offices.Add(new Office()
                    {
                        Id = id,
                        Name = $"Office_{id}",
                        Address = $"Address_{id}",
                        CreateDate = DateTime.Now,
                        UpdateTime = DateTime.Now,
                        CityId = cities[_rnd.Next(cities.Count)].Id,
                        OrganizationId = item.Id,
                    });
                    id++;
                }
            }
            int userscount = 50;
            id = 1;
            foreach (var organisation in organizations)
            {
                foreach (var office in offices.Where(x => x.OrganizationId == organisation.Id))
                {
                    for (int i = 0; i < userscount; i++)
                    {
                        users.Add(new User()
                        {
                            Id = id,
                            FirstName = $"FirstName_{id}",
                            LastName = $"LastName_{id}",
                            Email = $"Mail_{id}",
                            BirthDate = DateTime.Today,
                            Gender = $"RandomGender_{id}",
                            CreateDate = DateTime.Now,
                            UpdateTime = DateTime.Now,
                            IsFired = false,
                            OfficeId = office.Id,
                        });
                        id++;
                    }
                }
                userscount = userscount*10;
            }
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Organization>().HasData(organizations);
            modelBuilder.Entity<Office>().HasData(offices);
            modelBuilder.Entity<City>().HasData(cities);
            modelBuilder.Entity<Subscription>().HasData(
                new Subscription() {Id = 1, Cost = 0, Name = "Basic", AccessLevel = AccessLevel.Basic, MaxUsers = 100},
                new Subscription() {Id = 2, Cost = 0, Name = "Premium", AccessLevel = AccessLevel.Premium, MaxUsers = 1000 },
                new Subscription() { Id = 3, Cost = 0, Name = "Ultra", AccessLevel = AccessLevel.Ultra, MaxUsers = 10000 });
            modelBuilder.Entity<SubscriptionVersion>().HasData(new SubscriptionVersion() { Id = 1, Duration = 14, Name = "Trial" });
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
                optionsBuilder.UseLazyLoadingProxies().UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
                
            }
        }
    }

    
}
