using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantDashboard.Models.Option
{
    public class OptionModel : BaseEntityModel
    {
        public string OptionName { get; set; }

        public string Status { get; set; }
    }
}
