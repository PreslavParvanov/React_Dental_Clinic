using DentalClinic.BL.Contracts;
using DentalClinic.DB.Data.Models;
using DentalClinic.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using static DentalClinic.Areas.Admin.Constants.AdminConstants;

namespace DentalClinic.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        private readonly UserManager<User> userManager;

        public HomeController(ILogger<HomeController> logger
                            , UserManager<User> _userManager)
        {
            _logger = logger;
            userManager = _userManager;
        }

        public async Task<IActionResult> Index()
        {
            if (User.IsInRole(AdminRolleName))
            {
                return RedirectToAction("Index", "AdminHome", new { area = "Admin" });
            }

            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            ViewBag.UserName = "";
            if (userId != null)
            {
                var user = await userManager.FindByIdAsync(userId);
                ViewBag.UserName = $"{user.FirstName} {user.LastName}";
            }
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
