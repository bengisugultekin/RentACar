using System.Web.Mvc;

namespace RentACar.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult SignIn()
        {
            ViewBag.Header = "Login";
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(FormCollection form)
        {
            string email = form.Get("email");
            string passwoard = form.Get("password");

            if (email == "bengisu@domain.com" && passwoard == "1234")
            {
                Session["email"] = "bengisu@domain.com";
                Session["passwoard"] = "1234";
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                ViewBag.Message = "Hatalı giriş.";
                return View();
            }

        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("SignIn", "Login");
        }
    }
}