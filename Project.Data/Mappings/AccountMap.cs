using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Data.Models;
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
        }
    }
}
