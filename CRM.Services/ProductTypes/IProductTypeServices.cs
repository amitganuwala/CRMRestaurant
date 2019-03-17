using System;
using System.Collections.Generic;
using System.Text;
using CRM.Core.Domain.ProductTypes;

namespace CRM.Services.ProductTypes
{
    public partial interface IProductTypeServices
    {
        IList<ProductType> GetAllProductType(string ProductTypeName = null, string PunchLine = null, string Description = null,byte[] ProductTypeImage = null, string Status = null);

        ProductType GetProductTypeById(int ProductTypeId);

        /// <summary>
        /// Insert a ProductType
        /// </summary>
        /// <param name="ProductType">ProductType</param>
        void InsertProductType(ProductType productytype);

        /// <summary>
        /// Updates the ProductType
        /// </summary>
        /// <param name="ProductType">ProductType</param>
        void UpdateProductType(ProductType productytype);


        /// <summary>
        /// Delete a ProductType
        /// </summary>
        /// <param name="ProductType">ProductType</param>
        void DeleteProductType(ProductType productytype);

    }
}
