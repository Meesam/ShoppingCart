using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCartWeb.Areas.Authentication.Models
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Compare("Password", ErrorMessage = "Password do not match")]
        [DisplayName("Confirm password")]
        public string? ConfirmPassword { get; set; }
    }
}
