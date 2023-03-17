using Microsoft.AspNetCore.Mvc;

namespace DentalClinic.Controllers
{
    public class PriceListController : Controller
    {
        public IActionResult CreateDentist()
        {
            return View();
        }
    }
}
