using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    

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
    }
}