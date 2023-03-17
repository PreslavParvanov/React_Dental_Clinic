using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.BL.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace DentalClinic.Areas.Admin.Controllers
{
    [Authorize]
    public class ReceptionController : AdminBaseController
    {
        private readonly IReceptionService resectionService;
        private readonly IDentalService detnalServices;

        public ReceptionController(IReceptionService _resectionService
                                   ,IDentalService _detnalServices)
        {
            resectionService = _resectionService;
            detnalServices = _detnalServices;
        }

        [HttpGet]
        public IActionResult Reception()
        {
            ViewBag.dateSearch = DateTime.Now.ToString("yyyy-MM-dd");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Reception(DateTime DateSearch)
        {
            TimeSpan startTime = new TimeSpan(00, 00, 00);
            TimeSpan endTime = new TimeSpan(23, 59, 59);
            DateTime startDate = DateSearch + startTime;
            DateTime endDate = DateSearch + endTime;
            var result = await resectionService.GetAllBookedByDate(startDate, endDate);
            ViewBag.dateSearch = DateSearch;
            return View("ReceptionHdr", result);

        }

        [HttpPost]
        public async Task<IActionResult> ReceptionCustomer(Guid DoctorId, string CustomerId, DateTime curenttDate)
        {
            var detnalService = await detnalServices.GetAll();
            var result = await resectionService.GetBookedDetailsById(DoctorId, CustomerId, curenttDate, detnalService);
            return View("ReceptionCustomer", result);
        }

        [HttpPost]
        public async Task<IActionResult> ReceptionCustomerServices(ReceptionCustomerViewModel mode, Guid Test)
        {
            
            return View();
        }
    }
}
