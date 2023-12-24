using System.ComponentModel.DataAnnotations;

namespace HotelListing.DTOs.User
{
    public class LoginDTO
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        [StringLength(15,ErrorMessage ="Password length should be between {2} and {1} characters", MinimumLength =6)]
        public string Password { get; set; }
    }
}
