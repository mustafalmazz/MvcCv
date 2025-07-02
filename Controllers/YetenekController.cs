using System.Web.Mvc;
using MvcCv.Models.Entity;
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
        public ActionResult YeniYetenek()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniYetenek(TblYeteneklerim p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult YetenekSil(int id)
        {
            var yetenek = repo.Find(a => a.ID == id);
            repo.TDelete(yetenek);
            return RedirectToAction("Index");
        }
        public ActionResult YetenekDuzenle(int id)
        {
            var yetenek = repo.Find(m=>m.ID == id);
            return View(yetenek);
        }
        [HttpPost]
        public ActionResult YetenekDuzenle(TblYeteneklerim p)
        {
            var f = repo.Find(ot => ot.ID ==p.ID);
            f.Yetenek = p.Yetenek;
            f.Oran = p.Oran;
            repo.TUpdate(f);
            return RedirectToAction("Index"); 
        }

    }
}