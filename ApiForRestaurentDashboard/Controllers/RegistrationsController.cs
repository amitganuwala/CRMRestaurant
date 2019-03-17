using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CRM.Core.Domain.Registrations;
using CRM.Services.Registrations;
using CRM.Data.Mapping.Registrations;
using ApiForRestaurentDashboard.Models;
using ApiForRestaurentDashboard.Models.Registration;


namespace ApiForRestaurentDashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationsController : ControllerBase
    {
        #region fields

     public readonly  IRegistrationServices _registrationServices;

        #endregion


        #region ctors

        public RegistrationsController(IRegistrationServices registrationServices)
        {
            this._registrationServices = registrationServices;
        }

        #endregion

        #region methods



        [HttpGet]
        [Route("GetAllRegistrationList")]
        public IActionResult GetAllRegistrationList()
        {
            ResultModel resultModel = new ResultModel();
            try
            {
                var registrations = _registrationServices.GetAllRegistrations();

                var detail = registrations.Select(a => new RegistrationModel {

                    Id=a.Id,
                    CustFirstName=a.CustFirstName,
                    CustLastName=a.CustLastName,
                    EatingPreferance=a.EatingPreferance,
                    RAmount=a.RAmount,
                    Email=a.Email,
                    Gender=a.Gender,
                    Password=a.Password,
                    PhoneNo=a.PhoneNo,
                    ReferCode=a.ReferCode

                });


                if(registrations.Count!=0)
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


            }catch(Exception exp)
            {
                resultModel.Message = exp.ToString();
                resultModel.Status = 0;
                resultModel.Response = null;
            }

            return Ok(resultModel);
        }

        [HttpGet]
        [Route("GetRegistrationById")]
        public IActionResult GetRegistrationById(int Id)
        {
            ResultModel resultModel = new ResultModel();
            try
            {

                var registrations = _registrationServices.GetRegistrationById(Id);

                if(registrations!=null)
                {
                    resultModel.Message = ValidationMessages.Success;
                    resultModel.Status = 1;
                    resultModel.Response = registrations;
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


        //[HttpPost]
        //[Route("AddNewRegistrations")]
        //public IActionResult AddNewRegistrations(RegistrationModel model)
        //{
        //    ResultModel resultModel = new ResultModel();

        //    try
        //    {

        //        Registration registration =null;
        //        registration = new Registration {

        //            CustFirstName=model.CustFirstName,
        //            CustLastName = model.CustLastName,
        //            EatingPreferance = model.EatingPreferance,
        //            Email = model.Email,
        //            Password = model.Password,
        //            PhoneNo = model.PhoneNo,
        //            RAmount = model.RAmount,
        //            ReferCode= GenerateRandomChar() + GenerateRandomNo(),
        //            Gender=model.Gender
        //    };


        //        _registrationServices.InsertRegistration(registration);

        //        resultModel.Message = ValidationMessages.Success;
        //        resultModel.Status = 1;
        //        resultModel.Response = registration;


        //    }catch(Exception exp)
        //    {
        //        resultModel.Message = exp.ToString();
        //        resultModel.Status = 0;
        //        resultModel.Response = null;

        //    }

        //    return Ok(resultModel);
        //}


        [HttpPost]
        [Route("AddNewRegistrations")]
        public ActionResult AddNewRegistrations(RegistrationModel model)
        {
            ResultModel resultModel = new ResultModel();

            try
            {

                Registration registration = null;
                registration = new Registration
                {

                    CustFirstName = model.CustFirstName,
                    CustLastName = model.CustLastName,
                    EatingPreferance = model.EatingPreferance,
                    Email = model.Email,
                    Password = model.Password,
                    PhoneNo = model.PhoneNo,
                    RAmount = model.RAmount,
                    ReferCode = GenerateRandomChar() + GenerateRandomNo(),
                    Gender = model.Gender
                };


                _registrationServices.InsertRegistration(registration);

                resultModel.Message = ValidationMessages.Success;
                resultModel.Status = 1;
                resultModel.Response = registration;


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
        [Route("UpdateRegistrations")]
        public IActionResult UpdateRegistrations(RegistrationModel model)
        {
            ResultModel resultModel = new ResultModel();
            try
            {

                var _objUpdate = _registrationServices.GetRegistrationById(model.Id);

                _objUpdate.CustFirstName = model.CustFirstName;
                _objUpdate.CustLastName = model.CustLastName;
                _objUpdate.EatingPreferance = model.EatingPreferance;
                _objUpdate.Email = model.Email;
                _objUpdate.Password = model.Password;
                _objUpdate.PhoneNo = model.PhoneNo;
                _objUpdate.RAmount = model.RAmount;
                _objUpdate.Gender = model.Gender;

            


                _registrationServices.UpdateRegistration(_objUpdate);

                if (_objUpdate != null)
                {
                    resultModel.Message = ValidationMessages.Success;
                    resultModel.Status = 1;
                    resultModel.Response = _objUpdate;
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
                resultModel.Message = exp.ToString();
                resultModel.Status = 0;
                resultModel.Response = null;
            }


            return Ok(resultModel);
        }


        [HttpPost]
        [Route("DeleteRegistrations")]
        public IActionResult DeleteRegistrations(RegistrationModel model)
        {
            ResultModel resultModel = new ResultModel();

            try
            {

                Registration registration = null;
                registration = new Registration()
                {
                    CustFirstName = model.CustFirstName,
                    CustLastName = model.CustLastName,
                    EatingPreferance = model.EatingPreferance,
                    Email = model.Email,
                    Password = model.Password,
                    PhoneNo = model.PhoneNo,
                    RAmount = model.RAmount,
                    ReferCode = model.ReferCode,
                    Gender = model.Gender

                };



                _registrationServices.DeleteRegistration(registration);


                if (registration != null)
                {
                    resultModel.Message = ValidationMessages.Success;
                    resultModel.Status = 1;
                    resultModel.Response = registration;
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

        #endregion


        #region functions

        public static string GenerateRandomChar()
        {
            string result = string.Empty;
            Random random = new Random((int)DateTime.Now.Ticks);
            List<string> characters = new List<string>() { };
            for (int i = 65; i < 91; i++)
            {
                characters.Add(((char)i).ToString());
            }
            for (int i = 0; i < 4; i++)
            {
                result += characters[random.Next(0, characters.Count)];

            }
            return result;
        }
        //Generate RandomNo
        public int GenerateRandomNo()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }


        #endregion



    }
}