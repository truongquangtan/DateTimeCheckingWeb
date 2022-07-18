using DateTimeCheckingWeb.Models;
using DateTimeCheckingWeb.Supporters;

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DateTimeCheckingWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index([Bind("Day,Month,Year")] DateInputModel dateInputModel)
        {
            if (ModelState.IsValid)
            {
                int day = int.Parse(dateInputModel.Day!);
                int month = int.Parse(dateInputModel.Month!);
                int year = int.Parse(dateInputModel.Year!);

                if(DateValidator.IsValidDate(day, month, year))
                {
                    dateInputModel.Message = $"{day}/{month}/{year} is valid date";
                }
                else
                {
                    dateInputModel.Message = $"{day}/{month}/{year} is invalid date";
                }
            }
            return View(dateInputModel);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}