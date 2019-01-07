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
        public int Id_Autor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        public int Edad { get; set; }

        public virtual List<LibrosModel> Libros { get; set; }

    }
}