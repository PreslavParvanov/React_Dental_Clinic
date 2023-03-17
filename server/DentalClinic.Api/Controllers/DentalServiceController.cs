using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.BL.Service;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.Cors;

namespace DentalClinic.Api.Controllers
{
    [ApiController]
    [Route("/[controller]/[action]")]
    public class DentalServiceController : ControllerBase
    {
        private readonly IDentalService dentalService;
        /// <summary>
        /// DoctorService
        /// </summary>
        /// <param name="_dentalService"></param>
        public DentalServiceController(IDentalService _dentalService)
        {
            dentalService = _dentalService;
        }
        /// <summary>
        /// Get Dental Service
        /// </summary>
        /// <returns></returns>
        
        [HttpGet(Name = "GetDentalService")]
        [Produces("application/json")]
        [ProducesResponseType(200, StatusCode = StatusCodes.Status200OK, Type = typeof(IEnumerable<DentalServiceViewModel>))]
        public async Task<IActionResult> GetDentalService()
        {
            var teams = await dentalService.GetAll();
            if (teams == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(teams);
        }
    }
}
