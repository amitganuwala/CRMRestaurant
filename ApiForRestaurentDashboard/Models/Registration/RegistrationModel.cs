using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiForRestaurentDashboard.Models.Registration
{
    public class RegistrationModel:BaseEntityModel
    {
        public string CustFirstName { get; set; }

        public string CustLastName { get; set; }

        public string Email { get; set; }

        public string PhoneNo { get; set; }

        public string Password { get; set; }

        public string RAmount { get; set; }

        public string ReferCode { get; set; }

        public string EatingPreferance { get; set; }

        public string Gender { get; set; }

    }
}
