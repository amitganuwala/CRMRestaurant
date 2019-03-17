using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantDashboard.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult NewOrder()
        {
            return View();
        }

        public IActionResult UnderProcessOrder()
        {
            return View();
        }

        public IActionResult DeliveredOrder()
        {
            return View();
        }

        public IActionResult CancelledOrder()
        {
            return View();
        }


    }
}