using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eBado.Models.Account
{
    public class RegisterFormModel
    {
        public RegisterUserModel RegisterUser { get; set; }
        public RegisterPartTimeJobModel RegisterPartTimeJob { get; set; }
        public RegisterSelfEmployedModel RegisterSelfEmployed { get; set; }
        public RegisterCompanyModel RegisterCompany { get; set; }
    }
}