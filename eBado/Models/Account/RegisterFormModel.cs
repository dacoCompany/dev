using Web.eBado.Models.Account.RegisterHelper;

namespace Web.eBado.Models.Account
{
    public class RegisterFormModel 
    {
        public RegisterStandardUserModel RegisterUser { get; set; }
        public RegisterPartTimeJobModel RegisterPartTimeJob { get; set; }
        public RegisterSelfEmployedModel RegisterSelfEmployed { get; set; }
        public RegisterCompanyModel RegisterCompany { get; set; }
    }
}