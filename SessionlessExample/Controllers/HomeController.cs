using System.Web.Mvc;

namespace SessionlessExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session["Session"] = "123";
            return View();
        }
    }
}