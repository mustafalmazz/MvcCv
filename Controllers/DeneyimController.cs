using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class DeneyimController : Controller
    {
        // GET: Deneyim
        DeneyimRepository repo = new DeneyimRepository();
        public ActionResult Index()
        {
            var list = repo.List();
            return View(list);
        }
        public ActionResult DeneyimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeneyimEkle(TblDeneyimler deneyim)
        {
            repo.TAdd(deneyim);
            return RedirectToAction(nameof(Index));
        }
        public ActionResult DeneyimSil(int id)
        {
            TblDeneyimler t = repo.Find(a => a.ID == id);
            repo.TDelete(t);
            return RedirectToAction(nameof(Index));
        }
        public ActionResult DeneyimGetir(int id)
        {
            TblDeneyimler t = repo.Find(a => a.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult DeneyimGetir(TblDeneyimler deneyim)
        {
            TblDeneyimler t = repo.Find(z=>z.ID == deneyim.ID);
            t.Baslik = deneyim.Baslik;
            t.AltBaslik = deneyim.AltBaslik;
            t.Tarih = deneyim.Tarih;
            t.Aciklama = deneyim.Aciklama;
            repo.TUpdate(t);
            return RedirectToAction(nameof(Index));
        }
    }
}