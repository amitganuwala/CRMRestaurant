using System;
using System.Collections.Generic;
using System.Text;
using CRM.Data.Interfaces;
using CRM.Core.Domain.Products;
using System.Linq;

namespace CRM.Services.Products
{
    public class ProductServices : IProductServices
    {
        #region fields     
        private readonly IRepository<Product> _productRepository;
        #endregion

        #region ctor
        public ProductServices(
           IRepository<Product> productRepository)
        {
            this._productRepository = productRepository;
        }
        #endregion


        public void DeleteProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            //productytype.Deleted = true;
            UpdateProduct(product);

        }

        public IList<Product> GetAllProduct(int ProductTypeId = 0, string ProductName = null, decimal ProductCost = 0, string ProductType = null, int AddonId = 0, string Description = null, byte[] ProductTypeImage = null, string Status = null)
        {
            var query = _productRepository.Table;

            if (!string.IsNullOrWhiteSpace(ProductName))

                query = from pt in _productRepository.Table
                        orderby pt.ProductName
                        select pt;

            var Product_list = query.ToList();
            return Product_list;
        }

        public Product GetProductById(int ProductId)
        {
            if (ProductId == 0)
                return null;

            return _productRepository.GetById(ProductId);
        }

        public void InsertProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            _productRepository.Insert(product);
        }

        public void UpdateProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            _productRepository.Update(product);
        }
      
    }
}
