using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using LibreriaApp.Models;

namespace LibreriaApp.Controllers
{
    public class AutoresController : Controller
    {
        BaseContext con = new BaseContext();

        public ActionResult Index()
        {
            var data = from autor in con.Autores select autor;
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(AutoresModel data)
        {
            con.Autores.Add(data);
            con.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}