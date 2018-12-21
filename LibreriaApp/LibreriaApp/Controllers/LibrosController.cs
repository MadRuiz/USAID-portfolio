using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using LibreriaApp.Models;

namespace LibreriaApp.Controllers
{
    public class LibrosController : Controller
    {
        BaseContext con = new BaseContext();

        public ActionResult Index()
        {
            //query normalita
            //var query = from libro in con.Libros select libro;

            var query = (from libro in con.Libros
                            join autor in con.Autores on libro.Id_Autor equals autor.Id_Autor
                            orderby autor.Id_Autor
                            select new EscritosViewModel()
                            {
                               Autor = autor.Nombre + " " + autor.Apellido, 
                               Libro = libro.Nombre,
                               Paginas = libro.Paginas
                            }).ToList();

            return View(query);
        }
        public ActionResult Create()
        {
            ViewBag.Id_Autor = new SelectList(con.Autores, "Id_autor", "Nombre");
            return View();
        }
        [HttpPost]
        public ActionResult Create(LibrosModel data)
        {
            con.Libros.Add(data);
            con.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}