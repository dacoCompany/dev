using System.ComponentModel.DataAnnotations;

namespace Web.eBado.Models.Account.RegisterHelper
{
    public class RegisterSelfEmployedModel : RegisterBaseModel
    {
        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "PostalCode")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "Ico")]
        public int Ico { get; set; }

        [Display(Name = "Dic")]
        public string Dic { get; set; }

        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "Specialization")]
        public string Specialization { get; set; }
    }
}