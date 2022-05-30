using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Areas.JuanAdmin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("JuanAdmin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
