using System.Threading;
using System.Web.Mvc;

namespace SessionlessExample.Controllers
{
    public class SessionController : Controller
    {
        public ActionResult Index(int index)
        {
            Thread.Sleep(1000);
            return Content($"{index} - {Session["Session"]}, ");
        }
    }
}