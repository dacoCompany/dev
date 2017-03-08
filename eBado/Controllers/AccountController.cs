using System.Threading.Tasks;
using System.Web.Mvc;
using eBado.Models.Account;

namespace eBado.Controllers
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
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                {
                   ModelState.AddModelError("", "Login data is incorrect!");
                }
            }
            return View(model);
        }
    }
}