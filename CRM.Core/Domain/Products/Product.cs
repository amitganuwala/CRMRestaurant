using System;
using System.Collections.Generic;
using System.Text;
using CRM.Core.Domain.ProductTypes;


namespace CRM.Core.Domain.Products
{
    public partial class Product : BaseEntity
    {
        /// <summary>
        /// Gets or sets the ProductTypeId
        /// </summary>
        public int ProductTypeId { get; set; }

        /// <summary>
        /// Gets or sets the ProductName
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or sets the ProductCost
        /// </summary>
        public decimal ProductCost { get; set; }

        /// <summary>
        /// Gets or sets the ProductType
        /// </summary>
        public string ProductType { get; set; }

        /// <summary>
        /// Gets or sets the AddonId
        /// </summary>
        public int AddonId { get; set; }

        /// <summary>
        /// Gets or sets the Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the ProductTypeImage
        /// </summary>
        public byte[] ProductTypeImage { get; set; }

        /// <summary>
        /// Gets or sets the Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets the product
        /// </summary>
        public virtual ProductType producttype { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity has been deleted
        /// </summary>
        public bool Deleted { get; set; }


    }
}
