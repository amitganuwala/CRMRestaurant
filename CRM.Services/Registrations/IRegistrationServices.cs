using System;
using System.Collections.Generic;
using System.Text;
using CRM.Core.Domain.Registrations;

namespace CRM.Services.Registrations
{
   public partial interface IRegistrationServices
    {
        IList<Registration> GetAllRegistrations(string CustFirstName=null, string CustLastName=null, string Email=null, string PhoneNo=null, string Password=null, string RAmount=null, string ReferCode=null, string EatingPreferance=null, string Gender=null);

        Registration GetRegistrationById(int RegistrationId);

        /// <summary>
        /// Insert a Registration
        /// </summary>
        /// <param name="Registration">Registration</param>
        void InsertRegistration(Registration registration);

        /// <summary>
        /// Updates the Registration
        /// </summary>
        /// <param name="Registration">Registration</param>
        void UpdateRegistration(Registration registration);

        /// <summary>
        /// Delete a Registration
        /// </summary>
        /// <param name="Registration">Registration</param>
        void DeleteRegistration(Registration registration);

             


    }
}
