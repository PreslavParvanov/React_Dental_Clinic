using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.BL.Service;
using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using System.Security.Claims;

namespace DentalClinic.Controllers
{
    public class BookedController : Controller
    {
        private readonly IDoctorService doctorService;
        private readonly UserManager<User> userManager;
        private readonly IErrorService errorService;
        public BookedController(
            IDoctorService _doctor,
            UserManager<User> _userManager,
            IErrorService _errorService
            )
        {
            doctorService = _doctor;
            userManager = _userManager;
            errorService = _errorService;
        }

        [HttpGet]
        public async Task<IActionResult> Booked(string Title, Guid doctor,  DateTime dateStart, DateTime dateEnd, string message)
        {
            ViewBag.TitlePage = Title;
            ViewBag.Message = message;
            if (dateStart < DateTime.Now)
            {
                dateStart = DateTime.Now;
                dateEnd = DateTime.Now.AddDays(5);
            }
            
            var doctorSchedule = await doctorService.GetDoctorSchedule(doctor, dateStart, dateEnd);
            return View(doctorSchedule);
        }


        [HttpPost]
        public async Task<IActionResult> Booked(DoctorScheduleViewModel model, string Title)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            
            string customerName = "";
            string customerEmail = "";
            string customerPhone = "";

            if (userId != null)
            {
                model.Who = userId.ToString();
                var user = await userManager.FindByIdAsync(userId);
                customerName = $"{user.FirstName} {user.LastName}";
                customerEmail = user.Email;
                customerPhone = user.PhoneNumber;
            }
            model.IsBusy = true;
            if (ModelState.IsValid)
            {
                return View(model);
            }
            
            await doctorService.Booked(model, customerName, customerEmail, customerPhone);
            string message = $"Successfully booked for {model.startDate}";
            return RedirectToAction("Booked", "Booked", new { Title, doctor = model.DoctorId, message = message } );
        }
    }
}
