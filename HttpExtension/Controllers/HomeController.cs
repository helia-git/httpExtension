using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HttpExtension.Models;
using Microsoft.AspNetCore.Http;

namespace HttpExtension.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {

            HttpContext.SetSession("card", "123");
            return View();
        }

        public IActionResult Privacy()
        {
            
            ViewBag.card = HttpContext.GetSession<string>("card");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
