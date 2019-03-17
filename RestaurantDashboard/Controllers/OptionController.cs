using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurantDashboard.Models.Option;
using CRM.Core.Domain.Options;
using CRM.Services.Options;
using System.IO;
using Microsoft.AspNetCore.Http;
using CRM.Data.Interfaces;
using RestaurantDashboard.Utils;


namespace RestaurantDashboard.Controllers
{
    public class OptionController : BaseController
    {
        #region fields
        private readonly IOptionServices _optionService;

        #endregion

        #region CTOR
        public OptionController(
            IOptionServices optionService
          )
        {
            this._optionService = optionService;
        }
        #endregion

        public IActionResult CreateOption()
        {
            return View();
        }

        public IActionResult ListOption()
        {
            OptionListModel optionListModel = new OptionListModel();
            var option = _optionService.GetAllOption();
            foreach (var item in option)
            {
                optionListModel.ListOptionModel.Add(new OptionViewModel
                {
                    Id = item.Id,
                    OptionName = item.OptionName,                  
                    Status = item.Status,
                });
            }

            return View(optionListModel);
        }

        public virtual IActionResult EditOption(int id)
        {
            var option = _optionService.GetOptionById(id);

            if (option == null || option.Deleted)
                //No producttype found with the specified id
                return RedirectToAction("ListOption");

            //var model = new ProductTypeModel();
            var model = new OptionModel
            {

                OptionName = option.OptionName,                
                Status = option.Status,
            };
            
            return View(model);

        }

        [HttpPost]
        public virtual IActionResult EditOption(OptionModel opmodel, bool continueEditing)
        {
            try
            {

                var option = _optionService.GetOptionById(opmodel.Id);

                if (option == null || option.Deleted)
                    //No producttype found with the specified id
                    return RedirectToAction("ListOption");

                option.OptionName = opmodel.OptionName;
                option.Status = opmodel.Status;

                _optionService.UpdateOption(option);
                AddNotification(NotificationMessage.TitleSuccess, NotificationMessage.msgEditOption, NotificationMessage.TypeSuccess);
                return RedirectToAction("ListOption");
            }
            catch (Exception e)
            {
                AddNotification(NotificationMessage.TypeError, NotificationMessage.ErrormsgEditOption, NotificationMessage.TypeError);

                return View(e);
            }

        }


        [HttpPost]
        public IActionResult CreateOption(OptionModel model)
        {           
            Option option = null;
            option = new Option()
            {

                OptionName = model.OptionName,               
                Status = model.Status
            };
            _optionService.InsertOption(option);

            AddNotification(NotificationMessage.TitleSuccess, NotificationMessage.msgAddOption, NotificationMessage.TypeSuccess);


            return RedirectToAction("ListOption");
        }

    }
}