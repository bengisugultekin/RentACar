using RentACar.Models;
using System.Linq;
using System.Web.Mvc;

namespace RentACar.Controllers
{
    public class VehicleController : Controller
    {
        // View'ı yükleyen metot (Araç Ekleme Sayfası)
        public ActionResult Add()
        {
            if (Session["email"] != null)
            {
                ViewBag.Header = "Araç Ekle";
                return View();
            }
            else
            {
                return RedirectToAction("SignIn", "Login");

            }

        }

        // View'dan dönen Post işlemi yakalar (Araç Ekleme, Kaydetme işlemi)
        [HttpPost]
        public ActionResult Add(Vehicle model)
        {
            if (ModelState.IsValid)
            {
                using (RentACarDBContext db = new RentACarDBContext())
                {
                    db.Vehicle.Add(model);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("List", "Vehicle");
        }

        // View'ı yükleyen metot (Arabaları listeleme Sayfası)
        public ActionResult List()
        {
            if (Session["email"] != null)
            {
                ViewBag.Header = "Tüm Araçlar";

                using (RentACarDBContext db = new RentACarDBContext())
                {
                    // Silinmemiş Arabalar Listeleniyor
                    var result = db.Vehicle.Where(c => c.IsDeleted == false).ToList();

                    return View(result);
                }
            }
            else
            {
                return RedirectToAction("SignIn", "Login");

            }


        }

        // Araç Silme İşlemi
        public ActionResult Delete(int id)
        {
            using (RentACarDBContext db = new RentACarDBContext())
            {
                // Gelen id'ye ait aracı getirir ve IsDeleted özelliği true
                // yapıp listede görülmesini engeller
                var result = db.Vehicle.Find(id);
                result.IsDeleted = true;
                db.SaveChanges();

                return RedirectToAction("List", "Vehicle");
            }
        }
        [HttpPost]
        public ActionResult Rent(Rent model)
        {
            using (RentACarDBContext db = new RentACarDBContext())
            {
                db.Rent.Add(model);
                db.Vehicle.
                    FirstOrDefault(v => v.VehicleID == model.VehicleID).
                    IsRented = true;

                db.SaveChanges();
            }
            return RedirectToAction("List", "Vehicle");
        }
    }

}