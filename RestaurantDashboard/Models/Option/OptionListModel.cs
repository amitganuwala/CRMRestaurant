using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace RestaurantDashboard.Models.Option
{
    public class OptionListModel : BaseEntityModel
    {
        public OptionListModel()
        {
            ListOptionModel = new List<OptionViewModel>();
        }
        [DisplayName("SearchName")]
        public string SearchName { get; set; }

        public IList<OptionViewModel> ListOptionModel { get; set; }
    }

    public partial class OptionViewModel : BaseEntityModel
    {
        [DisplayName("Option Name")]
        public string OptionName { get; set; }
              
        [DisplayName("Status")]
        public string Status { get; set; }

        [DisplayName("Edit")]
        public string Edit { get; set; }
    }
}
