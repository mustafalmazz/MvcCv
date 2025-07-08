using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class SertifikaController : Controller
    {
        GenericRepository<TblSertifikalarim> repo = new GenericRepository<TblSertifikalarim>();
        // GET: Sertifika
        public ActionResult Index()
        {
            var srtf = repo.List();
            return View(srtf);
        }
        public ActionResult SertifikaGetir(int id)
        {
            var sertifika = repo.Find(z=>z.ID == id);
            ViewBag.d = id;
            return View(sertifika);
        }
        [HttpPost]
        public ActionResult SertifikaGetir(TblSertifikalarim p)
        {
            var sertifika = repo.Find(m=>m.ID == p.ID);
            sertifika.Aciklama = p.Aciklama;
            sertifika.Tarih = p.Tarih;
            repo.TUpdate(sertifika);
            return RedirectToAction("Index");
        }
        public ActionResult YeniSertifika()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSertifika(TblSertifikalarim p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult SertifikaSil(int id)
        {
            var sertifika = repo.Find(a=>a.ID == id);
            repo.TDelete(sertifika);
            return RedirectToAction("Index");
        }
    }
}