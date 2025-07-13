using Microsoft.Ajax.Utilities;
using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{

    [Authorize]
    public class EgitimController : Controller
    {
        EgitimRepository repo = new EgitimRepository();
        // GET: Egitim
        
        public ActionResult Index()
        {
            var egitim = repo.List();
            return View(egitim);
        }
        public ActionResult EgitimEkle()
        {
            return View();
        }
        [HttpPost] 
        public ActionResult EgitimEkle(TblEgitimlerim p)
        {
            if (!ModelState.IsValid)
            {
                return View("EgitimEkle");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult EgitimSil(int id)
        {
            var egitim = repo.Find(x => x.ID == id);
            repo.TDelete(egitim);
            return RedirectToAction("Index");
        }
        public ActionResult EgitimDuzenle(int id)
        {
            var egitim = repo.Find(x => x.ID == id);
            return View(egitim);
        }
        [HttpPost]
        public ActionResult EgitimDuzenle(TblEgitimlerim p)
        {
            if(!ModelState.IsValid)
            {
                return View("EgitimDuzenle");
            }
            var egitim = repo.Find(x => x.ID == p.ID);
            egitim.Baslik = p.Baslik;
            egitim.AltBaslik1 = p.AltBaslik1;
            egitim.AltBaslik2 = p.AltBaslik2;
            egitim.Tarih = p.Tarih;
            egitim.GNO = p.GNO;
            repo.TUpdate(egitim);
            return RedirectToAction("Index");
        }
    }
}