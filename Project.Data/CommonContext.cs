using AnthillCommon.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Unity;

namespace AnthillCommon.DataContext
{
    public class CommonContext : DbContext
    {
        //osipenkom: зачем тут контейнер если он не используется? лишняя зависимость получается
        protected IUnityContainer Container { get; private set; }

        public CommonContext(IUnityContainer container) : base()
        {
            Container = container;
        }
        public CommonContext() : base()
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new OrganizationMap());
            modelBuilder.ApplyConfiguration(new OfficeMap());
            modelBuilder.ApplyConfiguration(new CityMap());
            modelBuilder.ApplyConfiguration(new AccountMap());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               //osipenkom: коннекшен стринг нужно убирать в конфиг обязательно. это даёт возможность публиковать одно и то же приложение на разные серверы с разными коннекшен стрингами.
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Администратор\Documents\AnthillCommonBd.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }
    }

    
}
