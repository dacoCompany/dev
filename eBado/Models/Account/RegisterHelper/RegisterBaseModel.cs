using System.ComponentModel.DataAnnotations;

namespace Web.eBado.Models.Account.RegisterHelper
{
    public class RegisterBaseModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        protected string Email { get; set; }

        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("[0-9]{10}", ErrorMessage = "Must have 10 digits!")]
        protected string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        protected string Password { get; set; }
    }
}