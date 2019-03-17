using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CRM.Services.Addons;
using ApiForRestaurentDashboard.Models;
using ApiForRestaurentDashboard.Models.Addon;
using CRM.Core.Domain.Addons;
using System.IO;

namespace ApiForRestaurentDashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddonsController : ControllerBase
    {

        #region fields

        public readonly IAddonServices _addonServices;

        #endregion

        #region ctors
        public AddonsController(IAddonServices addonServices)
        {
            this._addonServices = addonServices;
        }
        #endregion

        #region methods



        [HttpGet]
        [Route("GetAddonList")]
        public IActionResult GetAddonList()
        {
            ResultModel resultModel = new ResultModel();
            try
            {
                var addons = _addonServices.GetAllAddons();

                var details = addons.Select(a => new AddonViewModel {

                    Id=a.Id,
                    AddonName=a.AddonName,
                    Description=a.Description,
                    Price=a.Price.ToString(),
                    AddonImage=a.AddonImage,
                    Status=a.Status


                });


                if(addons!=null)
                {
                    resultModel.Message = ValidationMessages.Success;
                    resultModel.Status = 1;
                    resultModel.Response = details;
                }else
                {
                    resultModel.Message = ValidationMessages.Failure;
                    resultModel.Status = 0;
                    resultModel.Response = null;
                }


            }catch(Exception exp)
            {
                resultModel.Message = exp.ToString();
                resultModel.Status = 0;
                resultModel.Response = null;
            }

            return Ok(resultModel);
        }

        [HttpGet]
        [Route("GetAddonListById")]
        public IActionResult GetAddonListById(int id)
        {
            ResultModel resultModel = new ResultModel();
            try
            {
                var addons = _addonServices.GetAddonById(id);

               
                if (addons != null)
                {
                    resultModel.Message = ValidationMessages.Success;
                    resultModel.Status = 1;
                    resultModel.Response = addons;
                }
                else
                {
                    resultModel.Message = ValidationMessages.Failure;
                    resultModel.Status = 0;
                    resultModel.Response = null;
                }


            }
            catch (Exception exp)
            {
                resultModel.Message = exp.ToString();
                resultModel.Status = 0;
                resultModel.Response = null;
            }

            return Ok(resultModel);
        }


        [HttpPost]
        [Route("AddNewAddons")]
        public IActionResult AddNewAddons(AddonModel model)
        {
            ResultModel resultModel = new ResultModel();
            try
            {
            

                Addon addon = null;
                addon = new Addon
                {

                    AddonName = model.AddonName,
                    Price = Convert.ToDecimal(model.Price),
                    Description = model.Description,
                    //AddonImage = addonbytes,
                    Status = model.Status
                };
                _addonServices.InsertAddon(addon);

                resultModel.Message = ValidationMessages.Success;
                resultModel.Status = 1;
                resultModel.Response = addon;

            }
            catch (Exception exp)
            {
                resultModel.Message = exp.ToString();
                resultModel.Status = 0;
                resultModel.Response = null;
            }

            return Ok(resultModel);
        }


        [HttpPost]
        [Route("AddNewAddonsByImage")]
        public IActionResult AddNewAddonsByImage(AddonModel model, IFormFile AddonImage)
        {
            ResultModel resultModel = new ResultModel();
            try
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
                    Price = Convert.ToDecimal(model.Price),
                    Description = model.Description,
                    AddonImage = addonbytes,
                    Status = model.Status
                };
                _addonServices.InsertAddon(addon);

                resultModel.Message = ValidationMessages.Success;
                resultModel.Status = 1;
                resultModel.Response = addon;

            }
            catch (Exception exp)
            {
                resultModel.Message = exp.ToString();
                resultModel.Status = 0;
                resultModel.Response = null;
            }

            return Ok(resultModel);
        }


        #endregion



    }
}