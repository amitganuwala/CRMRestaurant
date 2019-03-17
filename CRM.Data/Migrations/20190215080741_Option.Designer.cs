﻿// <auto-generated />
using System;
using CRM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRM.Data.Migrations
{
    [DbContext(typeof(dbContextCRM))]
    [Migration("20190215080741_Option")]
    partial class Option
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRM.Core.Domain.Addons.Addon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("AddonImage");

                    b.Property<string>("AddonName");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Description");

                    b.Property<string>("Price");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("Addons");
                });

            modelBuilder.Entity("CRM.Core.Domain.Options.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Deleted");

                    b.Property<string>("OptionName");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("Options");
                });

            modelBuilder.Entity("CRM.Core.Domain.ProductTypes.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Deleted");

                    b.Property<string>("Description");

                    b.Property<byte[]>("ProductTypeImage");

                    b.Property<string>("ProductTypeName");

                    b.Property<string>("PunchLine");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("ProductType");
                });
#pragma warning restore 612, 618
        }
    }
}