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
    }
}