using System;
using System.Collections.Generic;
using System.Text;
using CRM.Core.Domain.Products;

namespace CRM.Services.Products
{
    public partial interface IProductServices
    {

        IList<Product> GetAllProduct(int ProductTypeId = 0, string ProductName = null, decimal ProductCost = 0, string ProductType = null, int AddonId = 0, string Description = null, byte[] ProductTypeImage = null, string Status = null);

        Product GetProductById(int ProductId);

        /// <summary>
        /// Insert a Product
        /// </summary>
        /// <param name="Product">Product</param>
        void InsertProduct(Product product);

        /// <summary>
        /// Updates the Product
        /// </summary>
        /// <param name="Product">Product</param>
        void UpdateProduct(Product product);


        /// <summary>
        /// Delete a Product
        /// </summary>
        /// <param name="Product">Product</param>
        void DeleteProduct(Product product);


    }
}
