using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Core.Domain.Registrations
{
  public partial  class Registration:BaseEntity
    {
        /// <summary>
        /// Gets or sets the CustFirstName
        /// </summary>
        public string CustFirstName { get; set; }

        /// <summary>
        /// Gets or sets the CustLastName
        /// </summary>
        public string CustLastName { get; set; }

        /// <summary>
        /// Gets or sets the Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the PhoneNo
        /// </summary>
        public string PhoneNo { get; set; }

        /// <summary>
        /// Gets or sets the Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the RAmount
        /// </summary>
        public string RAmount { get; set; }

        /// <summary>
        /// Gets or sets the ReferCode
        /// </summary>
        public string ReferCode { get; set; }

        /// <summary>
        /// Gets or sets the EatingPreferance
        /// </summary>
        public string EatingPreferance { get; set; }

        /// <summary>
        /// Gets or sets the Gender
        /// </summary>
        public string Gender { get; set; }

    }
}
