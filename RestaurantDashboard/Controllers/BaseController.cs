using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantDashboard.Controllers
{
    public class BaseController : Controller
    {
        public virtual void AddNotification(string title, string message, string type)
        {
            TempData["title"] = title;
            TempData["message"] = message;
            TempData["type"] = type;
        }
    }
}