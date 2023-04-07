using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Api.Models
{
    public class UserApiViewModel
    {
        public string Id { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string AccessToken { get; set; } = null!;
    }
}
