using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantDashboard.Models.ProductType
{
    public class ProductTypeModel : BaseEntityModel
    {

        public string ProductTypeName { get; set; }

        public string PunchLine { get; set; }

        public string Description { get; set; }

        public byte[] ProductTypeImage { get; set; }

        public string Status { get; set; }


    }
}
