using AnthillCommon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Mapping
{
    public class AccountMap : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Account");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Login).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(255).IsRequired();
            builder.Property(x => x.NickName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.CreateDate).HasMaxLength(DateTime.MaxValue.ToString().Length).IsRequired();
            builder.Property(x => x.UpdateTime).HasMaxLength(DateTime.MaxValue.ToString().Length).IsRequired();
            builder.Property(x => x.Role).IsRequired(true);
            builder.Property(x => x.IsPaid).IsRequired(true);
            builder.Property(x => x.SubscriptionStartDate).HasMaxLength(DateTime.MaxValue.ToString().Length).IsRequired();
            builder.HasOne(x => x.Subscription).WithMany().HasForeignKey(x => x.SubscriptionId).IsRequired(false);
            builder.HasOne(x => x.SubscriptionVersion).WithMany().HasForeignKey(x => x.SubscriptionVersionId).IsRequired(false);
            builder.Property(x => x.OrganisationId).IsRequired(false);
        }
    }
}
