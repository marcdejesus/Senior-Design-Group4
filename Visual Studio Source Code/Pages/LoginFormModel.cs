using Syncfusion.Maui.DataForm;
using System.ComponentModel.DataAnnotations;

namespace WellnessApp
{
    public class LoginFormModel
    {
        [Display(Prompt = "example@mail.com", Name = "Email")]
        [Required, EmailAddress(ErrorMessage = "Enter your email - example@mail.com")]
        public required string Email { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter the password")]
        public required string Password { get; set; }


        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Enter your first name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Must contain only letters")]
        public required string First_Name { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Enter your last name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Must contain only letters")]

        public required string Last_Name { get; set; }

        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "Enter your date of birth")]
        [DataFormDateRange(ErrorMessage = "Date must be in the format MM/DD/YYYY")]
        public required string dob { get; set; }
    }
}