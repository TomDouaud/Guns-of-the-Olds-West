using Guns_of_the_Olds_West.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Guns_of_the_Olds_West.Controllers
{
    public class WinnerController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private PartyModel model;

        public WinnerController(ILogger<HomeController> logger)
        {
            _logger = logger;
            model = PartyModel.getInstance();
        }

        public IActionResult Index()
        {
            return View(this.model);
        }

        public IActionResult SendData(string firstname, string lastname, string email, string phone)
        {
            this.model.FirstName = firstname;
            this.model.LastName = lastname;
            this.model.Email = email;
            this.model.Phone = phone;
            this.model.DateOfTheParty = DateTime.Now;
            return RedirectToAction("Index", "Summary");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
