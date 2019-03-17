using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace RestaurantDashboard.Models.Gallery
{
    public class GalleryModel:BaseEntityModel
    {
        public byte[] GalleryImage { get; set; }

        public string AltText { get; set; }

        public string Status { get; set; }

    }
}
