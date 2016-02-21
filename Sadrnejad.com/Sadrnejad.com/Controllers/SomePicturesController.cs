using System.Net;
using System.Web.Mvc;

namespace Sadrnejad.com.Controllers
{
    public class SomePicturesController : Controller
    {
        // GET: SomePictures
        public ActionResult Index()
        {
            return View();
        }

        // GET: SomePictures/Details/5
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