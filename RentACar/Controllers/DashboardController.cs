using System.Web.Mvc;

namespace RentACar.Controllers
{
    public class DashboardController : Controller
    {
        public ActionResult Index()
        {
            if (Session["email"] != null)
            {
                ViewBag.Header = "Panel";
                return View();
            }
            else
            {
                return RedirectToAction("SignIn", "Login");
            }

        }
    }
}