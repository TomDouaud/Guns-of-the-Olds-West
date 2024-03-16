using Guns_of_the_Olds_West.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Guns_of_the_Olds_West.Controllers
{
    public class ReloadController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private PartyModel model;

        public ReloadController(ILogger<HomeController> logger)
        {
            _logger = logger;
            model = PartyModel.getInstance();
        }

        public IActionResult Index()
        {
            return View(this.model);
        }

        public IActionResult Reload(int numberOfBulletToReload)
        {

            switch (numberOfBulletToReload)
            {
                case 2:
                    model.Reload2();
                    break;
                case 7:
                    model.Reload7();
                    break;
                case 12:
                    model.Reload12();
                    break;
            }
            return RedirectToAction("Index", "Home");
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
