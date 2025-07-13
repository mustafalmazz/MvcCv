using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class AdminController : Controller
    {
        GenericRepository<TblAdmin> repo = new GenericRepository<TblAdmin>();
        // GET: Admin
        public ActionResult Index()
        {
            var liste = repo.List();
            return View(liste);
        }
        public ActionResult AdminEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminEkle(TblAdmin p)
        {
            repo.TAdd(p);
            return RedirectToAction(nameof(Index));
        }
        public ActionResult AdminSil(int id)
        {
            TblAdmin t = repo.Find(a => a.ID == id);
            repo.TDelete(t);
            return RedirectToAction(nameof(Index));
        }
        public ActionResult AdminDuzenle(int id)
        {
            TblAdmin t = repo.Find(a => a.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult AdminDuzenle(TblAdmin deneyim)
        {
            TblAdmin t = repo.Find(z => z.ID == deneyim.ID);
            t.KullaniciAdi = deneyim.KullaniciAdi;
            t.Sifre = deneyim.Sifre;
            repo.TUpdate(t);
            return RedirectToAction(nameof(Index));
        }
    }
}