using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using DentalClinic.BL.Service;
using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Security.Claims;
using System.Text;
using System.Web.Http;
using System.Web.Http.Cors;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using DentalClinic.Api.Models;

namespace DentalClinic.Api.Controllers
{
    [ApiController]
    [Authorize]
    [Microsoft.AspNetCore.Mvc.Route("/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly IConfiguration configuration;

        public UserController(
                                UserManager<User> _userManager,
                                SignInManager<User> _signInManager,
                                IConfiguration _configuration)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            configuration = _configuration;
            //logger = _logger;
        }

        [Microsoft.AspNetCore.Mvc.HttpPost(Name = "Registration")]
        [Produces("application/json")]

        [AllowAnonymous]
        public async Task<IActionResult> Registration(RegistrationViewModel model)
        {
            var user = new User()
            {
                UserName = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                PhoneNumber = model.Phonenumber,
                When = DateTime.Now,
                IsActive = 1
            };

            var result = await userManager.CreateAsync(user, model.Password);
            bool errorFlag = false;
            StringBuilder sb = new StringBuilder();
            foreach (var item in result.Errors)
            {
                errorFlag = true;
                sb.AppendLine(item.Description);
            }

            if (errorFlag)
            {
                return StatusCode(StatusCodes.Status400BadRequest, sb.ToString());
            }
            else
            {
                return Ok(model);
            }

        }

        [Microsoft.AspNetCore.Mvc.HttpPost(Name = "Login")]
        [Produces("application/json")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(UserViewModel model)
        {
            UserApiViewModel userApi = new UserApiViewModel();
            var user = await userManager.FindByNameAsync(model.Email);


            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);
                if (result.Succeeded)
                {
                    userApi.Id = user.Id;
                    userApi.FirstName = user.FirstName;
                    userApi.LastName = user.LastName;
                    userApi.AccessToken = GetToken(user);
                }
                else
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "Invalid login");
                }
            }
            else
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Invalid login");
            }

            return Ok(userApi);
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public string GetToken(User userDate)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, configuration["Jwt:Subject"]),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.Now.ToString()),
                new Claim("UserId", userDate.Id.ToString()),
                new Claim("DisplayName", userDate.FirstName.ToString()),
                new Claim("UserName", userDate.FirstName.ToString()),
                new Claim("Email", userDate.Email.ToString()),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                configuration["Jwt:Issuer"],
                configuration["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(20),
                signingCredentials: signIn);

            string AccessToken = new JwtSecurityTokenHandler().WriteToken(token);

            return AccessToken;
        }
    }
}
