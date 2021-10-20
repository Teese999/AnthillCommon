using AnthillCommon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthillCommon.Mapping
{
    public class OrganisationMap : IEntityTypeConfiguration<Organisation>
    {
        public void Configure(EntityTypeBuilder<Organisation> builder)
        {
            builder.ToTable("Organisation");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
            builder.Property(x => x.CreateDate).HasMaxLength(DateTime.MaxValue.ToString().Length).IsRequired();
            builder.Property(x => x.UpdateTime).HasMaxLength(DateTime.MaxValue.ToString().Length).IsRequired();
        }
    }
}
