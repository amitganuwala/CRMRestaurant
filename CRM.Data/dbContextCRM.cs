
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using CRM.Core.Domain.ProductTypes;
using CRM.Core.Domain.Products;
using CRM.Core.Domain.Addons;
using CRM.Core.Domain.Options;
using CRM.Core.Domain.Customers;
using CRM.Core.Domain.Gallerys;
using CRM.Core.Domain.Offers;
using CRM.Core.Domain.Registrations;

namespace CRM.Data
{
    public class dbContextCRM : DbContext
    {

        public dbContextCRM(DbContextOptions<dbContextCRM> options)
          : base(options)
        {

        }

        //Common
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Addon> Addons { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Gallery> Gallerys { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Registration> Registrations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
            .Where(type => !string.IsNullOrEmpty(type.Namespace))
            .Where(type => type.BaseType != null && type.BaseType.IsGenericType &&
                type.BaseType.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.ApplyConfiguration(configurationInstance);
            }
        }
        }
}
