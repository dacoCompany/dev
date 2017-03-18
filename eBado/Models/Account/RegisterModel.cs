using System.ComponentModel.DataAnnotations;

namespace Web.eBado.Models.Account
{
    public class RegisterModel 
    {
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }

        [Display(Name = "AccountName")]
        public string AccountName { get; set; }

        [Display(Name = "PostalCode")]
        public string PostalCode { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "CompanyName")]
        public string CompanyName { get; set; }

        [Display(Name = "Street")]
        public string Street { get; set; }

        [Display(Name = "StreetNumber")]
        public string StreetNumber { get; set; }

        [Display(Name = "Ico")]
        public string Ico { get; set; }

        [Display(Name = "Dic")]
        public string Dic { get; set; }

        [Display(Name = "Specialization")]
        public string Specialization { get; set; }
        public string AccountType { get; set; }
    }
}