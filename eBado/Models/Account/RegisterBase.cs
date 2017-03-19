using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.eBado.Models.Account
{
    public class RegisterBase
    {
        [Required(ErrorMessage = "Povinne pole")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Povinne pole")]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage = "Povinne pole")]
        [Display(Name = "AccountName")]
        public string AccountName { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }
    }
}