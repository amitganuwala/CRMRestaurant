using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace RestaurantDashboard.Controllers
{
    public class OffersController : Controller
    {
        #region fields


        #endregion



        public IActionResult CreateOffer()
        {
            return View();
        }

        public IActionResult ListOffer()
        {
            return View();
        }
    }
}