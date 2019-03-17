using System;
using System.Collections.Generic;
using System.Text;

using CRM.Core.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CRM.Data.Mapping.Products
{
    public partial class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.ToTable("Product");
            builder.HasKey(c => c.Id);
            builder.HasOne(c => c.producttype)
              .WithMany()
              .HasForeignKey(c => c.ProductTypeId);

            builder.Property(c => c.ProductName).HasMaxLength(1000);
            builder.Property(c => c.ProductCost).HasColumnType("decimal(18,4)");
            builder.Property(c => c.ProductTypeId).HasMaxLength(50);
            builder.Property(c => c.Description).HasMaxLength(1000);
            builder.Property(c => c.Status).HasMaxLength(50);

        }

    }
}

