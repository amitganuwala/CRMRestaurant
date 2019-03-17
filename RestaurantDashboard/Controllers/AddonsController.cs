using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRM.Core.Domain.Addons;
using RestaurantDashboard.Models.Addon;
using CRM.Services.Addons;
using System.IO;
using Microsoft.AspNetCore.Http;
using CRM.Data.Interfaces;
using RestaurantDashboard.Utils;


namespace RestaurantDashboard.Controllers
{
    public class AddonsController : BaseController
    {

        #region fields
        private readonly IAddonServices _addonService;

        #endregion

        #region CTOR
        public AddonsController(
            IAddonServices addonService

          )
        {

            this._addonService = addonService;

        }

        #endregion

        [HttpPost]
        public virtual IActionResult DeleteAddons(int id)
        {
            //var producttype = _producttypeService.GetProductTypeById(id);
            //if (producttype == null)
            //    //No producttype found with the specified id
            //    return RedirectToAction("ListProductType");
            ////delete item
            //_producttypeService.DeleteProductType(id);
            return View();
        }

       
        public IActionResult CreateAddons()
        {
            return View();
        }

        public IActionResult ListAddons()
        {
            AddonListModel addonListModel = new AddonListModel();
            var addon = _addonService.GetAllAddons();
            foreach (var item in addon)
            {
                addonListModel.ListAddonModel.Add(new AddonViewModel
                {
                    Id = item.Id,
                    AddonName = item.AddonName,
                    Price = item.Price.ToString(),
                    Description = item.Description,
                    AddonImage = item.AddonImage,
                    Status = item.Status,
                });
            }

            return View(addonListModel);
        }

             
        public virtual IActionResult EditAddons(int id)
        {
            var addon = _addonService.GetAddonById(id);

            if (addon == null || addon.Deleted)
                //No producttype found with the specified id
                return RedirectToAction("ListAddons");

            //var model = new ProductTypeModel();
            var model = new AddonModel
            {

                AddonName = addon.AddonName,
                Price = addon.Price,
                Description = addon.Description,
                AddonImage = addon.AddonImage,
                Status = addon.Status,
            };


            return View(model);

        }


        [HttpPost]
        public virtual IActionResult EditAddons(AddonModel admodel, bool continueEditing, IFormFile AddonImage)
        {
            try
            {
                byte[] addonbytes = null;
                using (var ms = new MemoryStream())
                {
                    try
                    {
                        AddonImage.CopyTo(ms);
                        addonbytes = ms.ToArray();
                    }
                    catch { }

                }

                var addon = _addonService.GetAddonById(admodel.Id);

                if (addon == null || addon.Deleted)
                    //No producttype found with the specified id
                    return RedirectToAction("ListAddons");

                addon.AddonName = admodel.AddonName;
                addon.Price = admodel.Price;
                addon.Description = admodel.Description;
                if (addonbytes == null)
                {
                    addon.AddonImage = addon.AddonImage;
                }
                else
                {
                    addon.AddonImage = addonbytes;
                }

                addon.Status = admodel.Status;

                _addonService.UpdateAddon(addon);
                AddNotification(NotificationMessage.TitleSuccess, NotificationMessage.msgEditAddon, NotificationMessage.TypeSuccess);
                return RedirectToAction("ListAddons");
            }
            catch (Exception e)
            {
                AddNotification(NotificationMessage.TypeError, NotificationMessage.ErrormsgEditAddon, NotificationMessage.TypeError);

                return View(e);
            }

        }

        [HttpPost]
        public IActionResult CreateAddons(AddonModel model, IFormFile AddonImage)
        {
            byte[] addonbytes;
            using (var ms = new MemoryStream())
            {
                AddonImage.CopyTo(ms);
                addonbytes = ms.ToArray();
            }

            Addon addon = null;
            addon = new Addon
            {

                AddonName = model.AddonName,
                Price = model.Price,
                Description = model.Description,
                AddonImage = addonbytes,
                Status = model.Status
            };
            _addonService.InsertAddon(addon);

            AddNotification(NotificationMessage.TitleSuccess, NotificationMessage.msgAddAddon, NotificationMessage.TypeSuccess);


            return RedirectToAction("ListAddons");
        }

    }
}