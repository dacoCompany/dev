using System.ComponentModel.DataAnnotations;

namespace Web.eBado.Models.Account.RegisterHelper
{
    public class RegisterPartTimeJobModel : RegisterBaseModel
    {
        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "PostalCode")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "Specialization")]
        public string Specialization { get; set; }
    }
}