using System.Linq;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers
{
    public class ServiceController : Controller
    {
        MyPortfolioDbEntities1 db = new MyPortfolioDbEntities1();
        public ActionResult Index()
        {
            var values = db.Service.ToList();
            return View(values);
        }
    }
}