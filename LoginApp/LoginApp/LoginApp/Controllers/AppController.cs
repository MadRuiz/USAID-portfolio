using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginApp.Models;
using System.Data.Entity;
using System.Security.Cryptography;

namespace Login.Controllers
{
    public class AppController : Controller
    {
        BaseContext bd = new BaseContext();
        CurrentUsersModel Helper = new CurrentUsersModel();

        public ActionResult Login()
        {
            if (Session["Id"] != null)
            {
                ViewBag.showing = false;
                return RedirectToAction("Index");
                

            }
            else
            {
               return View();
            }

            
        }
        [HttpPost]
        public ActionResult Login(string user, string pass)
        {
            string password = Helper.EncodePassword(pass);
            var foundUser = (from a in bd.Usuarios where a.Nombre == user && a.Pass == password select a).FirstOrDefault();
            if (foundUser != null )
            {
               Session["Id"] = foundUser.IdLogin;
               Session["Nombre"] = foundUser.Nombre;
                
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.showing = true;
                ViewBag.error = "Usuario o contraseña incorrectos";
                return View();
            }

        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            if (Session["Id"] != null)
            {

                return View(bd.Usuarios.ToList());

            }
            else
            {
                return View("Login");
            }
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(UsuariosModel data)
        {
            if (ModelState.IsValid)
            {
                string password = Helper.EncodePassword(data.Pass);

                var datos = new UsuariosModel()

                {
                    IdLogin = data.IdLogin,
                    Nombre = data.Nombre,
                    Mail = data.Mail,
                    Pass = password,
                    ConfirmPass = password,
                    Rol = data.Rol,
                    Descripcion = data.Descripcion
                };

                bd.Usuarios.Add(datos);
                bd.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");

            }



        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View("Index");
            }
            else
            {
                var datos = bd.Usuarios.Find(id);

                return View(datos);
            }


        }
        [HttpPost]
        public ActionResult Edit(UsuariosModel data)
        {

            if (ModelState.IsValid)
            {
                string password = Helper.EncodePassword(data.Pass);

                var datos = new UsuariosModel()

                {
                    IdLogin = data.IdLogin,
                    Nombre = data.Nombre,
                    Mail = data.Mail,
                    Pass = password,
                    ConfirmPass = password,
                    Rol = data.Rol,
                    Descripcion = data.Descripcion
                };
                bd.Entry(datos).State = EntityState.Modified;
                bd.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }


            

        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return View("Index");
            }
            else
            {
                return View(bd.Usuarios.Find(id));

            }
        }
        [HttpPost]
        public ActionResult Delete(int? id, UsuariosModel data)
        {
            if (id == null)
            {
                return View("Index");
            }
            else
            {
                var reg = bd.Usuarios.Find(id);
                bd.Usuarios.Remove(reg);
                bd.SaveChanges();
                return RedirectToAction("Index");

            }
        }

        
        public ActionResult Details(int ? id)
        {
            
            if (id == null)
            {
                return View("Index");
            }
            else
            {
                var reg = bd.Usuarios.Find(id);
                return View(reg);
            }

           
        }
    }
}
