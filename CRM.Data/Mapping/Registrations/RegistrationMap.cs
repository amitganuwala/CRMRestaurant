using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using CRM.Core.Domain.Registrations;

namespace CRM.Data.Mapping.Registrations
{
  public partial  class RegistrationMap : IEntityTypeConfiguration<Registration>
    {

        public void Configure(EntityTypeBuilder<Registration> builder)
        {

            builder.ToTable("Product");
            builder.HasKey(c => c.Id);
            builder.Property(u => u.CustFirstName).HasMaxLength(1000);
            builder.Property(u => u.CustLastName).HasMaxLength(1000);
            builder.Property(u => u.Email).HasMaxLength(1000);
            builder.Property(u => u.Password).HasMaxLength(1000);
            builder.Property(u => u.PhoneNo).HasMaxLength(20);
            builder.Property(u => u.RAmount).HasMaxLength(1000);
            builder.Property(u => u.ReferCode).HasMaxLength(1000);
            builder.Property(u => u.EatingPreferance).HasMaxLength(1000);
            builder.Property(u => u.Gender).HasMaxLength(1000);

        }
    }
}
