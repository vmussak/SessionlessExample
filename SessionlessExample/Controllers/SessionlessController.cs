using System.Web.Mvc;

namespace SessionlessExample.Controllers
{
    [SessionState(System.Web.SessionState.SessionStateBehavior.ReadOnly)]
    public class SessionlessController : Controller
    {
        public ActionResult Index(int index)
        {
            return Content($"{index} - {Session["Session"]}, ");
        }
    }
}