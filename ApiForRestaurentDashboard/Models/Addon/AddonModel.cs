using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiForRestaurentDashboard.Models.Addon
{
    public class AddonModel:BaseEntityModel
    {
        public string AddonName { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public byte[] AddonImage { get; set; }

        public string Status { get; set; }
    }
}
