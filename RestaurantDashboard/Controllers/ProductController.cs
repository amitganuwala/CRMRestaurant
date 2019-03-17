using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CRM.Core.Domain.Products;
using CRM.Services.Products;
using CRM.Services.ProductTypes;
using CRM.Services.Addons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurantDashboard.Models.Product;
using RestaurantDashboard.Utils;

namespace RestaurantDashboard.Controllers
{
    public class ProductController : BaseController
    {
        #region fields
        private readonly IProductServices _productService;
        private readonly IProductTypeServices _producttypeService;
        private readonly IAddonServices _addonService;

        #endregion

        #region CTOR
        public ProductController(
            IProductServices productService,
            IProductTypeServices productTypeServices,
            IAddonServices addonServices
          )
        {

            this._productService = productService;
            this._producttypeService = productTypeServices;
            this._addonService = addonServices;
        }
        #endregion

        public IActionResult CreateProduct()
        {
            var model = new ProductModel();

            model.AvailableProductType.Add(new SelectListItem { Text = "Select Product Type", Value = "0" });
            foreach (var c in _producttypeService.GetAllProductType())
            {
                model.AvailableProductType.Add(new SelectListItem
                {
                    Text = c.ProductTypeName,
                    Value = c.Id.ToString(),
                    Selected = c.Id == model.ProductTypeInfo.Id
                });
            }

            model.AvailableAddon.Add(new SelectListItem { Text = "Select Addon", Value = "0" });
            foreach (var c in _addonService.GetAllAddons())
            {
                model.AvailableAddon.Add(new SelectListItem
                {
                    Text = c.AddonName,
                    Value = c.Id.ToString(),
                    Selected = c.Id == model.AddonInfo.Id
                });
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductModel model, IFormFile ProductImage)
        {
            byte[] productbytes;
            using (var ms = new MemoryStream())
            {
                ProductImage.CopyTo(ms);
                productbytes = ms.ToArray();
            }

            Product product = null;
            product = new Product
            {
                ProductTypeId = model.ProductTypeInfo.Id,
                ProductName = model.ProductName,
                ProductCost = model.ProductCost,
                ProductType = model.ProductType,
                AddonId = model.AddonInfo.Id,
                Description = model.Description,
                ProductTypeImage = productbytes,
                Status = model.Status
            };
            _productService.InsertProduct(product);

            AddNotification(NotificationMessage.TitleSuccess, NotificationMessage.msgAddProductType, NotificationMessage.TypeSuccess);


            return RedirectToAction("ListProduct");
        }

        public IActionResult ListProduct()
        {
            ProductListModel productListModel = new ProductListModel();
            var product = _productService.GetAllProduct();
            foreach (var item in product)
            {
                productListModel.ListProductModel.Add(new ProductViewModel
                {                     
                    Id = item.Id,
                    ProductTypeName = item.producttype.ProductTypeName,
                    ProductName = item.ProductName,
                    ProductCost = item.ProductCost.ToString(),
                    ProductType = item.ProductType,
                    Description = item.Description,
                    ProductTypeImage = item.ProductTypeImage,
                    Status = item.Status,
                });
            }

            return View(productListModel);
        }

        public virtual IActionResult EditProduct(int id)
        {
            var product = _productService.GetProductById(id);

            if (product == null || product.Deleted)
                //No producttype found with the specified id
                return RedirectToAction("ListProduct");
            
            var model = new ProductModel
            {

                //ProductTypeId = product.ProductTypeId,
                //ProductName
                //PunchLine = product.PunchLine,
                //Description = product.Description,
                //ProductTypeImage = product.ProductTypeImage,
                //Status = product.Status,
            };


            return View(model);

        }
    }
}