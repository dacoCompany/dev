using System.Threading.Tasks;
using System.Web.Mvc;
using Web.eBado.Models.Account;

namespace Web.eBado.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                {
                   ModelState.AddModelError("", "Login data is incorrect!");
                }
            }
            return View(model);
        }

        [AllowAnonymous]
        public ActionResult RegisterNewAccount()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RegisterNewAccount(RegisterFormModel model)
        {
            if (ModelState.IsValid)
            {
                {
                    ModelState.AddModelError("", "Register data is incorrect!");
                }
            }
            return View(model);
        }

    }
}