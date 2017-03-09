using System.ComponentModel.DataAnnotations;

namespace Web.eBado.Models.Account.RegisterHelper
{
    public class RegisterCompanyModel : RegisterBaseModel
    {
        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "CompanyName")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "PostalCode")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "Ico")]
        public int Ico { get; set; }

        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "Dic")]
        public string Dic { get; set; }

        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "Specialization")]
        public string Specialization { get; set; }
    }
}