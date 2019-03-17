using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM.Core.Domain.ProductTypes;
using Microsoft.AspNetCore.Mvc;
using RestaurantDashboard.Models.ProductType;
using CRM.Services.ProductTypes;
using System.IO;
using Microsoft.AspNetCore.Http;
using CRM.Data.Interfaces;
using RestaurantDashboard.Utils;


namespace RestaurantDashboard.Controllers
{
    public class ProductTypeController : BaseController
    {
        #region fields
        private readonly IProductTypeServices _producttypeService;

        #endregion

        #region CTOR
        public ProductTypeController(
            IProductTypeServices producttypeService
          )
        {

            this._producttypeService = producttypeService;
        }
        #endregion

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateProductType()
        {
            return View();
        }

        [HttpPost]
        public virtual IActionResult DeleteProductType(int id)
        {
            //var producttype = _producttypeService.GetProductTypeById(id);
            //if (producttype == null)
            //    //No producttype found with the specified id
            //    return RedirectToAction("ListProductType");
            ////delete item
            //_producttypeService.DeleteProductType(id);
            return View();
        }

     
        public virtual IActionResult EditProductType(int id)
        {
            var producttype = _producttypeService.GetProductTypeById(id);
         
            if (producttype == null || producttype.Deleted)
                //No producttype found with the specified id
                return RedirectToAction("ListProductType");

            //var model = new ProductTypeModel();
            var model = new ProductTypeModel
            {

                ProductTypeName = producttype.ProductTypeName,
                PunchLine = producttype.PunchLine,
                Description = producttype.Description,
                ProductTypeImage = producttype.ProductTypeImage,
                Status = producttype.Status,
            };
                     

            return View(model);

        }

       
        [HttpPost]
        public virtual IActionResult EditProductType(ProductTypeModel ptmodel, bool continueEditing, IFormFile ProductTypeImage)
        {
            try
            {
                byte[] producttypebytes = null;
                using (var ms = new MemoryStream())
                {
                    try
                    {
                        ProductTypeImage.CopyTo(ms);
                        producttypebytes = ms.ToArray();
                    } catch { }
                   
                }

                var producttype = _producttypeService.GetProductTypeById(ptmodel.Id);

                if (producttype == null || producttype.Deleted)
                    //No producttype found with the specified id
                    return RedirectToAction("ListProductType");
                
                producttype.ProductTypeName = ptmodel.ProductTypeName;
                producttype.PunchLine = ptmodel.PunchLine;
                producttype.Description = ptmodel.Description;
                if(producttypebytes == null)
                {
                    producttype.ProductTypeImage = producttype.ProductTypeImage;
                }
                else
                {
                    producttype.ProductTypeImage = producttypebytes;
                }
                                
                producttype.Status = ptmodel.Status;

                _producttypeService.UpdateProductType(producttype);
                AddNotification(NotificationMessage.TitleSuccess, NotificationMessage.msgEditProductType, NotificationMessage.TypeSuccess);
                return RedirectToAction("ListProductType");
            }
            catch (Exception e)
            {
                AddNotification(NotificationMessage.TypeError, NotificationMessage.ErrormsgEditProductType, NotificationMessage.TypeError);

                return View(e);
            }

        }

        public IActionResult ListProductType()
        {
            ProductTypeListModel producttypeListModel = new ProductTypeListModel();
            var producttype = _producttypeService.GetAllProductType();
            foreach (var item in producttype)
            {
                producttypeListModel.ListProductTypeModel.Add(new ProductTypeViewModel
                {
                    Id = item.Id,
                    ProductTypeName = item.ProductTypeName,                    
                    PunchLine = item.PunchLine,
                    Description = item.Description,
                    ProductTypeImage = item.ProductTypeImage,
                    Status = item.Status,
                });
            }

            return View(producttypeListModel);
        }


        [HttpPost]
        public IActionResult CreateProductType(ProductTypeModel model,IFormFile ProductTypeImage)
        {
            byte[] producttypebytes;
            using (var ms = new MemoryStream())
            {
                ProductTypeImage.CopyTo(ms);
                producttypebytes = ms.ToArray();
            }
            
                ProductType producttype = null;
            producttype = new ProductType
            {  
              
                ProductTypeName = model.ProductTypeName,
                PunchLine = model.PunchLine,
                Description = model.Description,
                ProductTypeImage = producttypebytes,
                Status = model.Status
            };
            _producttypeService.InsertProductType(producttype);

            AddNotification(NotificationMessage.TitleSuccess, NotificationMessage.msgAddProductType, NotificationMessage.TypeSuccess);


            return RedirectToAction("ListProductType");
        }
    }
}