using System;
using System.Collections.Generic;
using System.Text;
using CRM.Core.Domain.Registrations;
using CRM.Data.Interfaces;
using System.Linq;
using CRM.Data;
using Microsoft.EntityFrameworkCore;

namespace CRM.Services.Registrations
{
    public class RegistrationServices : IRegistrationServices
    {


       

        #region fields

        private readonly IRepository<Registration> _registrationRepository;


        #endregion

        #region ctors

        public RegistrationServices(IRepository<Registration> registrationRepository)
        {
           this._registrationRepository = registrationRepository;
        }

        #endregion


        public IList<Registration> GetAllRegistrations(string CustFirstName = null, string CustLastName = null, string Email = null, string PhoneNo = null, string Password = null, string RAmount = null, string ReferCode = null, string EatingPreferance = null, string Gender = null)
        {
            var query = _registrationRepository.Table;

            if (!string.IsNullOrWhiteSpace(CustFirstName))

                query = from reg in _registrationRepository.Table
                        orderby reg.CustFirstName
                        select reg;

            var Registration_List = query.ToList();

            return Registration_List;
        }

        public Registration GetRegistrationById(int RegistrationId)
        {
            if (RegistrationId == 0)
                return null;

            return _registrationRepository.GetById(RegistrationId);
        }



        public void InsertRegistration(Registration registration)
        {
            if (registration == null)
                throw new ArgumentNullException(nameof(registration));

            _registrationRepository.Insert(registration); 
        }


        public void UpdateRegistration(Registration registration)
        {
            if (registration == null)
                throw new ArgumentNullException(nameof(registration));

             _registrationRepository.Update(registration);
        }



        public void DeleteRegistration(Registration registration)
        {
            if (registration == null)
                throw new ArgumentNullException(nameof(registration));

            _registrationRepository.Delete(registration);
        }


              
    }
}
