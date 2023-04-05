using DentalClinic.Api.Models;
using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.BL.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DentalClinic.Api.Controllers
{
    [ApiController]
    [Route("/[controller]/[action]")]
    public class ReportController : ControllerBase
    {
        private readonly IDoctorService doctorService;
        private readonly IReportService reportService;
        public ReportController(IDoctorService _doctorService, IReportService _reportService)
        {
            doctorService = _doctorService;
            reportService = _reportService;
        }

        [HttpGet(Name = "ReportDoctors")]
        [Produces("application/json")]
        [ProducesResponseType(200, StatusCode = StatusCodes.Status200OK, Type = typeof(IEnumerable<GetDoctorViewModel>))]
        public async Task<IActionResult> GetReportDoctors()
        {
            var teams = await doctorService.GetAll();
            if (teams == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(teams);
        }


        [HttpGet(Name = "GetDoctorSchedule")]
        [Produces("application/json")]
        [ProducesResponseType(200, StatusCode = StatusCodes.Status200OK, Type = typeof(IEnumerable<ReportDoctorScheduleViewModel>))]
        public async Task<IActionResult> GetDoctorSchedule(Guid DoctorId, DateTime StartDate, DateTime EndDate)
        {
            IEnumerable<ReportDoctorScheduleViewModel> result = null;
            try
            {
                result = await reportService.GetDentistScheduleByDate(DoctorId, StartDate, EndDate);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            
            return Ok(result);
        }
    }
}
