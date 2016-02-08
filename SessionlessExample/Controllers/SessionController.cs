using System.Web.Mvc;

namespace SessionlessExample.Controllers
{
    public class SessionController : Controller
    {
        public ActionResult Index(int index)
        {
            return Content($"{index} - {Session["Session"]}, ");
        }
    }
}