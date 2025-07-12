using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class SosyalMedyaController : Controller
    {
        GenericRepository<TblSosyalMedya> repo = new GenericRepository<TblSosyalMedya>();
        // GET: SosyalMedya
        public ActionResult Index()
        {
            var sosyal = repo.List();
            return View(sosyal);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(TblSosyalMedya p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult SayfaGetir(int id)
        {
            var hesap = repo.Find(x => x.ID == id);
            return View(hesap);
        }
        [HttpPost]
        public ActionResult SayfaGetir(TblSosyalMedya p)
        {
            var hesap = repo.Find(x => x.ID == p.ID);
            hesap.ikon = p.ikon;
            hesap.Durum = true;
            hesap.Ad = p.Ad;
            hesap.Link = p.Link;
            repo.TUpdate(hesap);
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var hesap = repo.Find(x => x.ID == id);
            hesap.Durum = false;
            repo.TUpdate(hesap);
            return RedirectToAction("Index");
        }
    }
}