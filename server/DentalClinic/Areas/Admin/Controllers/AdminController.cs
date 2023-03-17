using CloudinaryDotNet.Actions;
using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.BL.Service;
using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.Globalization;
using System.Security.Claims;

namespace DentalClinic.Areas.Admin.Controllers
{
    [Authorize]
    public class AdminController : AdminBaseController
    {
        private readonly IDoctorService doctorService;
        private readonly IErrorService errorService;
        private readonly ICloudinaryService cloudinaryService;


        public AdminController(
            IDoctorService _doctorService,
            ICloudinaryService _cloudinaryService,
            IErrorService _errorService)
        {
            doctorService = _doctorService;
            cloudinaryService = _cloudinaryService;
            errorService = _errorService;
        }

        [HttpGet]
        public IActionResult CreateDentist()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDentist(DoctorViewModel model, IFormFile img)
        {
            var filePath = Path.GetTempFileName();
            if (img!=null)
            {
                
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await img.CopyToAsync(stream);
                }
            }
            else
            {
                return View(model);
            }
            
            
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (userId != null)
            {
                model.Who = userId.ToString();
            }

            if (ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                var result = await doctorService.GetAll();
                var doctor = result.Where(d => d.Name.ToUpper() == model.Name.ToUpper()).FirstOrDefault();
                if (doctor == null)
                {
                    var imageUrl = await cloudinaryService.UploadImage(filePath);
                    model.ImageUrl = imageUrl;
                    await doctorService.Create(model);
                }
                else
                {
                    ModelState.AddModelError("", "This doctor exists!");
                    return View(model);
                }

            }
            catch (Exception ex)
            {
                await errorService.DCLog(ex);
                ModelState.AddModelError("", "Something went wrong. Try shorter.");
                return View(model);
            }
            return RedirectToAction("CreateDentist", "AdminController");
        }

        [HttpGet]
        public async Task<IActionResult> CreateSchedule(string info)
        {
            ViewBag.Info = info;
            var model = new DoctorScheduleViewModel()
            {
                Doctors = await doctorService.GetDoctorsAsync()
            };
            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> CreateSchedule(DoctorScheduleViewModel doctorScheduleViewModel, TimeSpan startTime, TimeSpan endTime)
        {
            ViewData["Title"] = "Dental Clinic";
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (userId != null)
            {
                doctorScheduleViewModel.Who = userId.ToString();
            }

            if (ModelState.IsValid)
            {
                doctorScheduleViewModel.Doctors = await doctorService.GetDoctorsAsync();
                return View(doctorScheduleViewModel);
            }
            if (doctorScheduleViewModel.endDate <= doctorScheduleViewModel.startDate)
            {
                ModelState.AddModelError("", "end Date is < or = on start Date!");
                doctorScheduleViewModel.Doctors = await doctorService.GetDoctorsAsync();
                return View(doctorScheduleViewModel);
            }
            if (endTime <= startTime)
            {
                ModelState.AddModelError("", "end Time is < or = on start Time!");
                doctorScheduleViewModel.Doctors = await doctorService.GetDoctorsAsync();
                return View(doctorScheduleViewModel);
            }
            var result = await doctorService.GetDoctorSchedule(doctorScheduleViewModel.DoctorId, doctorScheduleViewModel.startDate, doctorScheduleViewModel.endDate);
            if (result.Count() == 0)
            {
                try
                {
                    await doctorService.CreateSchedule(doctorScheduleViewModel, startTime, endTime);
                    string info = $"The schedule has been added successfully.";
                    
                    return RedirectToAction(nameof(CreateSchedule), new { info = info });
                }
                catch (Exception ex)
                {
                    await errorService.DCLog(ex);
                    ModelState.AddModelError("", "Something went wrong. Try shorter.");
                    return View(doctorScheduleViewModel);
                }
            }
            else
            {
                ModelState.AddModelError("", $"The doctor has a schedule from {startTime} to {endTime}!");
                doctorScheduleViewModel.Doctors = await doctorService.GetDoctorsAsync();
                return View(doctorScheduleViewModel);
            }


        }
    }
}
