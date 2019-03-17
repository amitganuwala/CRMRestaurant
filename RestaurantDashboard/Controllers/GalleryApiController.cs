using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantDashboard.Models.Gallery;
using CRM.Core.Domain.Gallerys;
using CRM.Data;
using CRM.Services.Gallerys;
using RestaurantDashboard.Models;


namespace RestaurantDashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleryApiController : ControllerBase
    {

        #region fields

        public readonly IGalleryServices _galleryServices;

        #endregion


        #region ctor

        public GalleryApiController(IGalleryServices galleryServices)
        {
            this._galleryServices = galleryServices;
        }

        #endregion



        [HttpGet(Name ="GetGalleryLists")]
        [Route("GetGalleryLists")]
        public IActionResult GetGalleryLists()
        {
            ResultModel resultModel = new ResultModel();

            try
            {
                var gallery = _galleryServices.GetAllGallery();


               var detail = gallery.Select(a=>new GalleryViewModel
                    {

                        Id = a.Id,
                        GalleryImage = a.GalleryImage,
                        AltText = a.AltText,
                        Status = a.Status

                    });

                if (gallery != null)
                {
                    resultModel.Message = ValidationMessages.Success;
                    resultModel.Status = 1;
                    resultModel.Response = detail;
                }
                else
                {
                    resultModel.Message = ValidationMessages.Failure;
                    resultModel.Status = 0;
                    resultModel.Response = null;
                }

            }
            catch(Exception exp)
            {

            }

            return Ok(resultModel);

        }

    }
}