using DentalClinic.DB.Data.Models;
using DentalClinic.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using static DentalClinic.Areas.Admin.Constants.AdminConstants;

namespace DentalClinic.Areas.Admin.Controllers
{
    public class AdminHomeController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
