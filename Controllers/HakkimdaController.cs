using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class HakkimdaController : Controller
    {
       GenericRepository<TblHakkimda> repo = new GenericRepository<TblHakkimda>();
        // GET: Hakkimda
        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }
        [HttpPost]
        public ActionResult Index(TblHakkimda p)
        {
            var t = repo.Find(a=>a.ID == 1);
            t.Ad = p.Ad;
            t.Soyad = p.Soyad;
            t.Adres = p.Adres;
            t.Telefon = p.Telefon;
            t.Mail = p.Mail;
            t.Aciklama = p.Aciklama;
            t.Resim = p.Resim;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}