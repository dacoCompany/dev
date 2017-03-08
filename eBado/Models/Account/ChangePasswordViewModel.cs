﻿using System.ComponentModel.DataAnnotations;

namespace eBado.Models.Account
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Your must provide a Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Old Password")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Your must provide a Password")]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Your must provide a Password")]
        [DataType(DataType.Password)]
        [Display(Name = "New Password again")]
        public string ConfirmNewPassword { get; set; }
    }
}