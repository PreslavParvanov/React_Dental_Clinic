using CloudinaryDotNet.Actions;
using DentalClinic.Api.Models;
using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Web.Http;

namespace DentalClinic.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("/[controller]/[action]")]
    public class BookedController : ControllerBase
    {
        private readonly IDoctorService doctorService;
        private readonly UserManager<User> userManager;
        public BookedController(IDoctorService _doctorService, UserManager<User> _userManager)
        {
            doctorService = _doctorService;
            userManager = _userManager;
        }

        
        [Microsoft.AspNetCore.Mvc.HttpPost(Name = "GetDentistSchedule")]
        [Produces("application/json")]
        public async Task<IActionResult> GetDentistSchedule(BookedByDateModel bookedbyDateModel)
        {
            var schadule = await doctorService.GetDoctorSchedule(bookedbyDateModel.DoctorId, bookedbyDateModel.StartDate, bookedbyDateModel.EndDate);

            if (schadule == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(schadule);
        }

        [Microsoft.AspNetCore.Mvc.HttpPost(Name = "Booked")]
        [Produces("application/json")]
        public async Task<IActionResult> Booked(BookedModel bookedModel)
        {
            DoctorScheduleViewModel doctorScheduleViewModel = new DoctorScheduleViewModel();
            doctorScheduleViewModel.DoctorId = bookedModel.DoctorId;
            doctorScheduleViewModel.startDate = bookedModel.DateBooked;
            doctorScheduleViewModel.Who = bookedModel.User;
            var user = await userManager.FindByIdAsync(bookedModel.User);
            try
            {
                var schadule = await doctorService.GetDoctorSchedule(bookedModel.DoctorId, bookedModel.DateBooked, bookedModel.DateBooked);
                if (schadule.Count() >0)
                {
                    var currSchadule = schadule.First();
                    if (currSchadule.IsBusy)
                    {
                        return StatusCode(StatusCodes.Status400BadRequest, "This reservation is busy");
                    }
                    if (user != null)
                    {

                        await doctorService.Booked(doctorScheduleViewModel, user.FirstName + user.LastName, user.Email, user.PhoneNumber);
                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status400BadRequest, "Invalid user");
                    }
                }
                else
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "Invalid doctor");
                }

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            return Ok();
        }
    }
}
