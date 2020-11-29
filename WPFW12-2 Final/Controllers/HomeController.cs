using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WPFW12_2_Final.Data;
using WPFW12_2_Final.Models;

namespace WPFW12_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly WPFW12_2_FinalContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, WPFW12_2_FinalContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewDataToevoegen();
            return View();
        }

        public IActionResult Privacy()
        {
            ViewDataToevoegen();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            ViewDataToevoegen();
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private void ViewDataToevoegen()
        {
            ViewData["Huisnummer"] = _context.Student.Where(m => m.Huisnummer > 100).Take(3).OrderByDescending(m => m.Huisnummer);
        }
    }
}
