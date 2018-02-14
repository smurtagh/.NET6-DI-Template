using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyClient.Models;
using MyManager;

namespace MyClient.Controllers
{
    public class HomeController : Controller
    {
        private Shared.IServiceProvider _serviceProvider;
        public HomeController(Shared.IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IActionResult Index()
        {
            var testMeResult = _serviceProvider.GetService<IMyManager>().TestMe("test");
            return View("Index", testMeResult);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
