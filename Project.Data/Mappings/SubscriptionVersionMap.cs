using AnthillCommon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Mapping
{
    public class SubscriptionVersionMap : IEntityTypeConfiguration<SubscriptionVersion>
    {
        public void Configure(EntityTypeBuilder<SubscriptionVersion> builder)
        {
            builder.ToTable("SubscriptionVersion");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Duration).IsRequired(true);
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
        }
    }
}
