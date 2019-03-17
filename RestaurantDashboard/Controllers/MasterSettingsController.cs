using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantDashboard.Controllers
{
    public class MasterSettingsController : Controller
    {
        public IActionResult AppSettings()
        {
            return View();
        }

        public IActionResult PaypalSettings()
        {
            return View();
        }

        public IActionResult PayuSettings()
        {
            return View();
        }

        public IActionResult EmailSettings()
        {
            return View();
        }

        public IActionResult EmailTemplates()
        {
            return View();
        }

        public IActionResult SmsGateways()
        {
            return View();
        }



        public IActionResult SmsTemplates()
        {
            return View();
        }

        public IActionResult PushNotifications()
        {
            return View();
        }
    }
}