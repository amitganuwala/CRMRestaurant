using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantDashboard.Models.ProductType
{
    public partial class ProductTypeListModel : BaseEntityModel
    {
        public ProductTypeListModel()
        {
            ListProductTypeModel = new List<ProductTypeViewModel>();
        }
        [DisplayName("SearchName")]
        public string SearchName { get; set; }

        public IList<ProductTypeViewModel> ListProductTypeModel { get; set; }
    }

    public partial class ProductTypeViewModel : BaseEntityModel
    {
        [DisplayName("ProductType Name")]
        public string ProductTypeName { get; set; }

        [DisplayName("PunchLine")]
        public string PunchLine { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("ProductTypeImage")]
        public byte[] ProductTypeImage { get; set; }

        //[DataType(DataType.EmailAddress)]
        //[Required(ErrorMessage = "Use valid emailId")]
        //public string Email { get; set; }

        [DisplayName("Status")]
        public string Status { get; set; }

        [DisplayName("Edit")]
        public string Edit { get; set; }


    }

}
