using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantDashboard.Controllers
{
    public class NotificationsController : Controller
    {
        public IActionResult SendNotification()
        {
            return View();
        }

        public IActionResult ListNotifications()
        {
            return View();
        }
    }
}