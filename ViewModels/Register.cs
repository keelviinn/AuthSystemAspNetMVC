using System.ComponentModel.DataAnnotations;

namespace AspNetAuthPim.ViewModels
{
    public class Register
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "The Password and Password Confirmation must match!")]
        public string ConfirmPassword { get; set; }
    }
}
