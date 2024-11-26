using System.ComponentModel.DataAnnotations;

namespace WellnessApp
{
    public class LoginFormModel
    {
        [Display(Prompt = "example@mail.com", Name = "Email")]
        [EmailAddress(ErrorMessage = "Enter your email - example@mail.com")]
        public required string Email { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter the password")]
        public required string Password { get; set; }
    }
}