using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurantDashboard.Models.ProductType;
using RestaurantDashboard.Models.Addon;

namespace RestaurantDashboard.Models.Product
{
    public class ProductModel : BaseEntityModel
    {

        public ProductModel()
        {
            ProductTypeInfo = new ProductTypeModel();
            this.AvailableProductType = new List<SelectListItem>();

            AddonInfo = new AddonModel();
            this.AvailableAddon = new List<SelectListItem>();
        }

        public IList<SelectListItem> AvailableProductType { get; set; }
        public IList<SelectListItem> AvailableAddon { get; set; }

        public int ProductTypeId { get; set; }
             
        public string ProductName { get; set; }

        public decimal ProductCost { get; set; }

        public string ProductType { get; set; }

        public int AddonId { get; set; }

        public string Description { get; set; }

        public byte[] ProductTypeImage { get; set; }

        public string Status { get; set; }

        public ProductTypeModel ProductTypeInfo { get; set; }

        public AddonModel AddonInfo { get; set; }

    }
}
