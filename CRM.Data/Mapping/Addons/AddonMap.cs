using CRM.Core.Domain.Addons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Data.Mapping.Addons
{
   
    public partial class AddonMap : IEntityTypeConfiguration<Addon>
    {
        public void Configure(EntityTypeBuilder<Addon> builder)
        {

            builder.ToTable("Addon");
            builder.HasKey(c => c.Id);
            builder.Property(u => u.AddonName).HasMaxLength(1000);
            builder.Property(u => u.Price).HasColumnType("decimal(18,4)");
            builder.Property(u => u.Description).HasMaxLength(1000);
            builder.Property(u => u.Status).HasMaxLength(50);
            
        }
    }
}
