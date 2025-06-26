using System.Web.Mvc;
using MvcCv.Repositories;
namespace MvcCv.Controllers
{
    public class YetenekController : Controller
    {
        YetenekRepository repo = new YetenekRepository();
        // GET: Yetenek
        public ActionResult Index()
        {
            var listem = repo.List();
            return View(listem);
        }
    }
}