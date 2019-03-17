using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRM.Core.Domain.Gallerys;
using CRM.Services.Gallerys;
using RestaurantDashboard.Models.Gallery;
using Microsoft.AspNetCore.Http;
using RestaurantDashboard.Utils;
using System.IO;

namespace RestaurantDashboard.Controllers
{
    public class GalleryController : BaseController
    {

        #region fields

        public readonly IGalleryServices _galleryServices;

        #endregion


        #region ctor

        public GalleryController(IGalleryServices galleryServices )
        {
            this._galleryServices = galleryServices;
        }

        #endregion


        #region methods

        public IActionResult GalleryList()
        {
            GalleryListModel galleryListModel = new GalleryListModel();
            var gallery = _galleryServices.GetAllGallery();

            foreach(var item in gallery)
            {
                galleryListModel.ListGalleryModel.Add(new GalleryViewModel {

                    Id = item.Id,
                    GalleryImage=item.GalleryImage,
                    AltText=item.AltText,
                    Status=item.Status

                });

            }

         
                return View(galleryListModel);
        }


        public IActionResult CreateGallery()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateGallery(GalleryModel model,IFormFile GalleryImage)
        {
            byte[] gallerybytes;

            using (var ms=new MemoryStream())
            {
                GalleryImage.CopyTo(ms);
                gallerybytes = ms.ToArray();
            }

            Gallery gallery = null;

            gallery = new Gallery
            {
                GalleryImage = gallerybytes,
                AltText = model.AltText,
                Status=model.Status

            };

            _galleryServices.InsertGallery(gallery);

            AddNotification(NotificationMessage.TitleSuccess, NotificationMessage.msgAddGallery, NotificationMessage.TypeSuccess);


            return RedirectToAction("GalleryList");
        }



        public virtual IActionResult EditGallery(int id)
        {
            var gallery = _galleryServices.GetGalleryById(id);

            
            if (gallery == null || gallery.Deleted)     //If the record is not find by id then
                return RedirectToAction("GalleryList");

            var model = new GalleryModel {

                GalleryImage = gallery.GalleryImage,
                AltText=gallery.AltText,
                Status=gallery.Status

            };

            return View(model);
        }


        [HttpPost]
        public virtual IActionResult EditGallery(GalleryModel model,IFormFile GalleryImage)
        {
            try
            {
                byte[] gallerybytes = null;
                using (var ms = new MemoryStream())
                {
                    try
                    {
                        GalleryImage.CopyTo(ms);
                        gallerybytes = ms.ToArray();
                    }
                    catch { }
                }



                var gallery = _galleryServices.GetGalleryById(model.Id);

                if (gallery == null || gallery.Deleted)
                    return RedirectToAction("GalleryList");

               
                gallery.AltText = model.AltText;

                if(gallerybytes==null)
                {
                    gallery.GalleryImage = model.GalleryImage;
                }
                else
                {
                    gallery.GalleryImage = gallerybytes;
                }

                gallery.Status = model.Status;

                _galleryServices.UpdateGallery(gallery);
                AddNotification(NotificationMessage.TitleSuccess, NotificationMessage.msgEditGallery, NotificationMessage.TypeSuccess);

                return RedirectToAction("GalleryList");

            }catch(Exception exp)
            {
                AddNotification(NotificationMessage.TitleError, NotificationMessage.ErrormsgEditGallery, NotificationMessage.TypeError);

                return View(exp);
            }

           
        }


        public virtual IActionResult DeleteGallery(int id)
        {
            var gallery = _galleryServices.GetGalleryById(id);

            if (gallery == null)
                return RedirectToAction("GalleryList");

            _galleryServices.DeleteGallery(gallery);

            return RedirectToAction("GalleryList");
        }

        #endregion


    }
}