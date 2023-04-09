using DentalClinic.Api.Models;
using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.BL.Service;
using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Web.Http;

namespace DentalClinicApi.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("/[controller]/[action]")]

    public class TeamController : ControllerBase
    {
        private readonly IDoctorService doctorService;
        /// <summary>
        /// DoctorService
        /// </summary>
        /// <param name="_doctorService"></param>
        public TeamController(IDoctorService _doctorService)
        {
            doctorService = _doctorService;
        }
        /// <summary>
        /// Get All doctors
        /// </summary>
        /// <returns></returns>
        [Microsoft.AspNetCore.Mvc.HttpGet(Name = "GetAllDoctors")]
        [Produces("application/json")]
        [ProducesResponseType(200, StatusCode = StatusCodes.Status200OK, Type = typeof(IEnumerable<GetDoctorViewModel>))]
        public async Task<IActionResult> GetAllDoctors()
        {
            var teams = await doctorService.GetAll();
            if (teams == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(teams);
        }

        /// <summary>
        /// Get doctor by Id
        /// </summary>
        /// <param name="doctorId"></param>
        /// <returns></returns>
        [Microsoft.AspNetCore.Mvc.HttpGet(Name = "GetDoctorById")]
        [Produces("application/json")]
        [ProducesResponseType(200, StatusCode = StatusCodes.Status200OK, Type = typeof(IEnumerable<GetDoctorViewModel>))]

        public async Task<IActionResult> GetDoctorById(Guid doctorId)
        {
            var teams = await doctorService.GetDoctorById(doctorId);
            if (teams == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(teams);
        }

        [Authorize]
        [Microsoft.AspNetCore.Mvc.HttpPost(Name = "CreateDoctor")]
        [Produces("application/json")]

        public async Task<IActionResult> CreateDoctor(DoctorViewModel doctor)
        {

            try
            {
                await doctorService.Create(doctor);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            return Ok(doctor);
        }

        [Authorize]
        [Microsoft.AspNetCore.Mvc.HttpDelete(Name = "DeleteDoctor")]
        [Produces("application/json")]

        public async Task<IActionResult> DeleteDoctor(Guid doctorId, string who)
        {

            try
            {
                await doctorService.Delete(doctorId, who);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            return Ok();
        }

        [Authorize]
        [Microsoft.AspNetCore.Mvc.HttpPut(Name = "UpdateDoctor")]
        [Produces("application/json")]

        public async Task<IActionResult> UpdateDoctor(DoctorViewModel doctor)
        {

            try
            {
                await doctorService.Update(doctor);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            return Ok(doctor);
        }

        [Authorize]
        [Microsoft.AspNetCore.Mvc.HttpPost(Name = "CreateSchedule")]
        [Produces("application/json")]
        public async Task<IActionResult> CreateSchedule(DoctorScheduleModel doctorScheduleModel)
        {
            TimeSpan startTime = TimeSpan.Parse(doctorScheduleModel.startTime);
            TimeSpan endTime = TimeSpan.Parse(doctorScheduleModel.endTime);
            DoctorScheduleViewModel doctorScheduleViewModel = new DoctorScheduleViewModel();
            doctorScheduleViewModel.DoctorId = doctorScheduleModel.DoctorId;
            doctorScheduleViewModel.startDate = doctorScheduleModel.startDate;
            doctorScheduleViewModel.endDate = doctorScheduleModel.endDate;
            doctorScheduleViewModel.IsBusy = doctorScheduleModel.IsBusy;
            doctorScheduleViewModel.Who = doctorScheduleModel.Who;

            if (doctorScheduleViewModel.endDate < doctorScheduleViewModel.startDate)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "end Date is < on start Date!");
            }
            if (endTime <= startTime)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "end Time is < or = on start Time!");
            }
            var result = await doctorService.GetDoctorSchedule(doctorScheduleViewModel.DoctorId, doctorScheduleViewModel.startDate, doctorScheduleViewModel.endDate);
            if (result.Count() == 0)
            {
                try
                {
                    await doctorService.CreateSchedule(doctorScheduleViewModel, startTime, endTime);
                    return Ok("The schedule has been added successfully.");
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            else
            {
                return StatusCode(StatusCodes.Status400BadRequest, $"The doctor has a schedule from {startTime} to {endTime}!");
            }


        }
    }
}
