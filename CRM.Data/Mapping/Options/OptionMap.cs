using System;
using System.Collections.Generic;
using System.Text;
using CRM.Core.Domain.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Data.Mapping.Options
{
    public partial class OptionMap : IEntityTypeConfiguration<Option>
    {
        public void Configure(EntityTypeBuilder<Option> builder)
        {

            builder.ToTable("Option");
            builder.HasKey(c => c.Id);
            builder.Property(u => u.OptionName).HasMaxLength(1000);          
            builder.Property(u => u.Status).HasMaxLength(50);
        }
    }
}
