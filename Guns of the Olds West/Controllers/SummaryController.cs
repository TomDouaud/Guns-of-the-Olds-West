using Guns_of_the_Olds_West.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Guns_of_the_Olds_West.Controllers
{
    public class SummaryController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private PartyModel model;

        public SummaryController(ILogger<HomeController> logger)
        {
            _logger = logger;
            model = PartyModel.getInstance();
        }

        public IActionResult Index()
        {
            return View(this.model);
        }

        public IActionResult RestartGame()
        {
            this.model.BulletsRemaining = 12;
            this.model.MoneySpent = 0;
            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
