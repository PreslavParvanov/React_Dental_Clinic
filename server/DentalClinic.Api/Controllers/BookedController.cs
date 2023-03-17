using CloudinaryDotNet.Actions;
using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace DentalClinic.Api.Controllers
{
    [ApiController]
    [Route("/[controller]/[action]")]
    public class BookedController : ControllerBase
    {
        private readonly IDoctorService doctorService;
        /// <summary>
        /// DoctorService
        /// </summary>
        /// <param name="_dentalService"></param>
        public BookedController(IDoctorService _doctorService)
        {
            doctorService = _doctorService;
        }
        /// <summary>
        /// Get Dental Service
        /// </summary>
        /// <returns></returns>

        [HttpGet(Name = "GetDentistSchedule")]
        [Produces("application/json")]
        [ProducesResponseType(200, StatusCode = StatusCodes.Status200OK, Type = typeof(IEnumerable<DoctorScheduleViewModel>))]
        public async Task<IActionResult> GetDentistSchedule(Guid doctorId, DateTime dateStart, DateTime dateEnd)
        {
            var schadule = await doctorService.GetDoctorSchedule(doctorId, dateStart, dateEnd);
            if (schadule == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(schadule);
        }

        [HttpPost(Name = "Booked")]
        [Produces("application/json")]
        public async Task<IActionResult> Booked(Guid doctorId,DateTime dateBooked,string user, string customerName, string customerEmail, string customerPhone)
        {
            DoctorScheduleViewModel doctorScheduleViewModel = new DoctorScheduleViewModel();
            doctorScheduleViewModel.DoctorId = doctorId;
            doctorScheduleViewModel.startDate = dateBooked;
            doctorScheduleViewModel.Who=user;
            try
            {
                var schadule = await doctorService.GetDoctorSchedule(doctorId, dateBooked, dateBooked);
                await doctorService.Booked(doctorScheduleViewModel, customerName, customerEmail, customerPhone);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            
            return Ok();
        }
    }
}
