using System.Web.Mvc;

namespace MyPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead() 
        {
            return PartialView();
        }
    }
}