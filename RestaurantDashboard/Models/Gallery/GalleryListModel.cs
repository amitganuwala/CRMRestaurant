using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace RestaurantDashboard.Models.Gallery
{
    public class GalleryListModel:BaseEntityModel
    {
        public GalleryListModel()
        {
            ListGalleryModel = new List<GalleryViewModel>();
        }

        [DisplayName("SearchName")]
        public string SearchName { get; set; }


        public IList<GalleryViewModel> ListGalleryModel { get; set; }

    }


    public partial class GalleryViewModel:BaseEntityModel
    {
        [DisplayName("GalleryImage")]
        public byte[] GalleryImage { get; set; }

        [DisplayName("AltText")]
        public string AltText { get; set; }

        [DisplayName("Status")]
        public string Status { get; set; }

        [DisplayName("Edit")]
        public string Edit { get; set; }

    }

}
