using DentalClinic.BL.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DentalClinic.Controllers
{
    public class TeamController : Controller
    {
        private readonly IDoctorService doctorService;
        private readonly IErrorService errorService;
        public TeamController(
            IDoctorService _doctorService,
            IErrorService _errorService
            )
        {
            doctorService = _doctorService;
            errorService = _errorService;
        }
        [HttpGet]
        public async Task<IActionResult> Team()
        {

            var doctors = await doctorService.GetAll();
            return View(doctors);
        }

        [HttpPost]
        public async Task<IActionResult> Team(Guid doctor, string doctorName)
        {
            string Title = $"Booked: {doctorName}";
            return RedirectToAction("Booked", "Booked", new { Title, doctor = doctor });
        }

    }
}
