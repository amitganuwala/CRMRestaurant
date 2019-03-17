using System;
using System.Collections.Generic;
using System.Text;
using CRM.Core.Domain.ProductTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Data.Mapping.ProductTypes
{
    public partial class ProductTypeMap : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {

            builder.ToTable("Product");
            builder.HasKey(c => c.Id);           
            builder.Property(u => u.ProductTypeName).HasMaxLength(1000);
            builder.Property(u => u.PunchLine).HasMaxLength(1000);
            builder.Property(u => u.Description).HasMaxLength(1000);
            builder.Property(u => u.Status).HasMaxLength(50);
        }
    }
}
