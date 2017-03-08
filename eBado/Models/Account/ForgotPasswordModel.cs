using System.ComponentModel.DataAnnotations;

namespace eBado.Models.Account
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}