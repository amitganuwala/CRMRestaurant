using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace RestaurantDashboard.Models.Product
{
    public class ProductListModel : BaseEntityModel
    {
        public ProductListModel()
        {
            ListProductModel = new List<ProductViewModel>();
        }
        [DisplayName("SearchName")]
        public string SearchName { get; set; }

        public IList<ProductViewModel> ListProductModel { get; set; }
    }

    public partial class ProductViewModel : BaseEntityModel
    {
      
        [DisplayName("ProductType Name")]
        public string ProductTypeName { get; set; }

        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [DisplayName("Product Cost")]
        public string ProductCost { get; set; }

        [DisplayName("Product Type")]
        public string ProductType { get; set; }

        [DisplayName("Addon")]
        public string Addon { get; set; }

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
