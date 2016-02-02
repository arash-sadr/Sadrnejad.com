using System.Web.Mvc;
using System.Net;

namespace Sadrnejad.com.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Porfolio
        public ActionResult Index()
        {
            return View();
        }

        // GET: Portfolio/Details/5
        public ActionResult Details(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View(title);
        }
    }
}