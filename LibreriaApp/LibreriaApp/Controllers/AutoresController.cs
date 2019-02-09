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
<<<<<<< HEAD
            var query = from autor in con.Autores select autor;
            
            return View(query.ToList());
=======
            var data = from autor in con.Autores select autor;
            return View(data);
>>>>>>> 764457860f9a075f181c7e5b6fc4fc5c3cc520c4
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
<<<<<<< HEAD
=======

>>>>>>> 764457860f9a075f181c7e5b6fc4fc5c3cc520c4
            return RedirectToAction("Index");
        }
    }
}