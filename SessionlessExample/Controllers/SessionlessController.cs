using System.Threading;
using System.Web.Mvc;

namespace SessionlessExample.Controllers
{
    [SessionState(System.Web.SessionState.SessionStateBehavior.ReadOnly)]
    public class SessionlessController : Controller
    {
        public ActionResult Index(int index)
        {
            Thread.Sleep(1000);
            return Content($"{index} - {Session["Session"]}, ");
        }
    }
}