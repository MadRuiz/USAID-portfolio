using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using LoginApp.Models;

namespace LoginApp.Controllers
{
    public class DemoController : Controller
    {

        TablasModel tabla = new TablasModel();
        PersonasModel persona = new PersonasModel();

        public ActionResult Tablas()
        {
            ViewBag.showing = false;
            return View();
        }
        [HttpPost]
        public ActionResult Tablas(int num)
        {
            ViewBag.showing = true;
            int res = Convert.ToInt32(Request["num"]);
            ViewBag.resultado = tabla.Calcular(res);
            return View();
        }

        public ActionResult Edad()
        {
            ViewBag.showing = false;
            return View();
        }
        [HttpPost]
        public ActionResult Edad(int bornYear)
        {
            ViewBag.showing = true;
            int edad = persona.CalcularEdad(bornYear);
            ViewBag.result = edad + " años";
            return View();
        }
    }
}