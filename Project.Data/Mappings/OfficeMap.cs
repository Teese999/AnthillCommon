using AnthillCommon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthillCommon.Mapping
{
    public class OfficeMap : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("Office");
            builder.HasKey(x => x.Id);
            //builder.Property(x => x.Id).UseIdentityColumn(0, 1);
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Address).HasMaxLength(255).IsRequired();
            builder.Property(x => x.CreateDate).HasMaxLength(DateTime.MaxValue.ToString().Length).IsRequired();
            builder.Property(x => x.UpdateTime).HasMaxLength(DateTime.MaxValue.ToString().Length).IsRequired();
            builder.HasOne(x => x.Organization).WithMany().HasForeignKey(x => x.OrganizationId).IsRequired(false);
            builder.HasOne(x => x.City).WithMany().HasForeignKey(x => x.CityId).IsRequired(false);
        }
    }
}
