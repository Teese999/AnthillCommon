using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AnthillCommon.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnthillCommon.Mapping
{
    public class SubscriptionMap : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.ToTable("Subscription");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Cost).IsRequired(true);
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
            builder.Property(x => x.SubscriptionSequrity).IsRequired();
        }
    }
}
