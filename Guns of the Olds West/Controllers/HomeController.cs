using Guns_of_the_Olds_West.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Guns_of_the_Olds_West.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private PartyModel model;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            model = PartyModel.getInstance();
        }

        public IActionResult Index()
        {
            return View(this.model);
        }

        [HttpPost]
        public IActionResult Shoot()
        {
            if (this.model.BulletsRemaining == 0)
            {
                return RedirectToAction("Index", "Reload");
            }
            else
            {
                model.Shoot();
                if (this.model.numberPicked < 4)
                {
                    return RedirectToAction("Index", "Winner");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
