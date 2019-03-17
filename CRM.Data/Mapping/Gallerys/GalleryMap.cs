using System;
using System.Collections.Generic;
using System.Text;
using CRM.Core.Domain.Gallerys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Data.Mapping.Gallerys
{
    class GalleryMap:IEntityTypeConfiguration<Gallery>
    {
        public void Configure(EntityTypeBuilder<Gallery> builder)
        {

            builder.ToTable("Gallery");
            builder.HasKey(c => c.Id);
            builder.Property(u => u.AltText).HasMaxLength(1000);
            builder.Property(u => u.Status).HasMaxLength(50);
        }

    }
}
