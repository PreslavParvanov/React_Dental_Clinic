using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.BL.Service;
using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DentalClinic.Controllers
{
    public class DentalServicesController : Controller
    {
        private readonly IDentalService detnalServices;
        private readonly IErrorService errorService;
        public DentalServicesController(
            IDentalService _detnalServices,
            IErrorService _errorService
            )
        {
            detnalServices = _detnalServices;
            errorService = _errorService;
        }

        [HttpGet]
        public async Task<IActionResult> DentalServices()
        {
            var dentalServices = await detnalServices.GetAll();
            return View(dentalServices);
        }
    }
}
