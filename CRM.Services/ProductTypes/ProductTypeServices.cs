using System;
using System.Collections.Generic;
using System.Text;
using CRM.Data.Interfaces;
using CRM.Core.Domain.ProductTypes;
using System.Linq;

namespace CRM.Services.ProductTypes
{
    public class ProductTypeServices : IProductTypeServices
    {
        
        #region fields     
        private readonly IRepository<ProductType> _producttypeRepository;
        #endregion

        #region ctor
        public ProductTypeServices(
           IRepository<ProductType> producttypeRepository)
        {
            this._producttypeRepository = producttypeRepository;
        }
        #endregion

        #region ProductType

        public IList<ProductType> GetAllProductType(string ProductTypeName = null, string PunchLine = null, string Description = null, byte[] ProductTypeImage = null, string Status = null)
        {
            var query = _producttypeRepository.Table;

            if (!string.IsNullOrWhiteSpace(ProductTypeName))

                query = from pt in _producttypeRepository.Table
                        orderby pt.ProductTypeName
                        select pt;
          
            var ProductType_list = query.ToList();
            return ProductType_list;

        }

        #endregion

        public ProductType GetProductTypeById(int ProductTypeId)
        {
            if (ProductTypeId == 0)
                return null;

            return _producttypeRepository.GetById(ProductTypeId);
        }

        /// <summary>-
        /// Insert a ProductType
        /// </summary>
        /// <param name="ProductType">ProductType</param>
         public virtual void InsertProductType(ProductType productytype)
        {
            if (productytype == null)
                throw new ArgumentNullException(nameof(productytype));

            _producttypeRepository.Insert(productytype);

        }

        /// <summary>-
        /// Update a ProductType
        /// </summary>
        /// <param name="ProductType">ProductType</param>
        public void UpdateProductType(ProductType productytype)
        {
            if (productytype == null)
                throw new ArgumentNullException(nameof(productytype));

            _producttypeRepository.Update(productytype);
        }

        /// <summary>-
        /// Delete a ProductType
        /// </summary>
        /// <param name="ProductType">ProductType</param>
        public void DeleteProductType(ProductType productytype)
        {
            if (productytype == null)
                throw new ArgumentNullException(nameof(productytype));

            //productytype.Deleted = true;
            UpdateProductType(productytype);

        }

    }
}
