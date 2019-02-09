using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibreriaApp.Models
{
    public class AutoresModel
    {
        [Key]
<<<<<<< HEAD
        public int Id_Autor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        public int Edad { get; set; }
=======
        [Display(Name = "ID")]
        public int Id_Autor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
>>>>>>> 764457860f9a075f181c7e5b6fc4fc5c3cc520c4

        public virtual List<LibrosModel> Libros { get; set; }

    }
}