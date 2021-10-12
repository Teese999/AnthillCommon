using AnthillCommon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthillCommon.Mapping
{
    public class OrganizationMap : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.ToTable("Organization");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
            builder.Property(x => x.CreateDate).HasMaxLength(DateTime.MaxValue.ToString().Length).IsRequired();
            builder.Property(x => x.UpdateTime).HasMaxLength(DateTime.MaxValue.ToString().Length).IsRequired();
        }
    }
}
