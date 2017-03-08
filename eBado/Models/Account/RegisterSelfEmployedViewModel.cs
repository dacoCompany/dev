﻿using System.ComponentModel.DataAnnotations;

namespace eBado.Models.Account
{
    public class RegisterSelfEmployedViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("[0-9]{10}", ErrorMessage = "Must have 10 digits!")]
        public string PhoneNumber1 { get; set; }
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