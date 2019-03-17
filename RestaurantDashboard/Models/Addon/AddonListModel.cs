using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantDashboard.Models.Addon
{
   
    public partial class AddonListModel : BaseEntityModel
    {
        public AddonListModel()
        {
            ListAddonModel = new List<AddonViewModel>();
        }
        [DisplayName("SearchName")]
        public string SearchName { get; set; }

        public IList<AddonViewModel> ListAddonModel { get; set; }
    }

    public partial class AddonViewModel : BaseEntityModel
    {

        [DisplayName("Addon Name")]
        public string AddonName { get; set; }

        [DisplayName("Price")]
        public string Price { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("AddonImage")]
        public byte[] AddonImage { get; set; }

        [DisplayName("Status")]
        public string Status { get; set; }

        [DisplayName("Edit")]
        public string Edit { get; set; }
        
    }
}
