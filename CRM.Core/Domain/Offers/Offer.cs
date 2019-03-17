using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Core.Domain.Offers
{
   public partial class Offer:BaseEntity
    {
        /// <summary>
        /// Gets or sets the OfferName
        /// </summary>
        public string OfferName { get; set; }

        ///<summary>
        //Gets or sets the OfferCost
        ///<summary>
        public decimal OfferCost { get; set; }

        ///<summary>
        //Gets or sets the OfferStartDate
        ///<summary>
        public DateTime OfferStartDate { get; set; }

        ///<summary>
        //Gets or sets the OfferValidDate
        ///<summary>
        public DateTime OfferValidDate { get; set; }

        ///<summary>
        //Gets or sets the ServeNoOfPeople
        ///<summary>
        public int ServeNoOfPeople { get; set; }

        ///<summary>
        //Gets or sets the OfferImage
        ///<summary>
        public byte[] OfferImage { get; set; }

        ///<summary>
        //Gets or sets the OfferCondition
        ///<summary>
        public string OfferCondition { get; set; }

        ///<summary>
        //Gets or sets the Status
        ///<summary>
        public string Status { get; set; }

    }
}
