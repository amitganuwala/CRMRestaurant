using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantDashboard.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult CustomerList()
        {
            return View();
        }

        public IActionResult CustomerDetails()
        {
            return View();
        }
    }
}