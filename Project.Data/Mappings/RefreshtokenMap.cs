using AnthillCommon.Services.Contracts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Mapping
{
    public class RefreshtokenMap : IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.ToTable("RefreshToken");
            builder.HasKey(x => x.id);
            builder.Property(x => x.AccountId).IsRequired();
            builder.Property(x => x.Token).HasMaxLength(255).IsRequired();
            builder.Property(x => x.ExpiryDate).HasMaxLength(DateTime.MaxValue.ToString().Length).IsRequired();
            builder.HasOne(x => x.Account).WithMany().HasForeignKey(x => x.AccountId).IsRequired(true);

        }
    }
}
