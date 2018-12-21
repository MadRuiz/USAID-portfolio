using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibreriaApp.Models
{
    public class LibrosModel
    {
        [Key]
        [Display(Name = "ID")]
        public int Id_Libro { get; set; }
        public string Nombre { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [Display(Name = "Páginas")]
        public int Paginas { get; set; }

        public int Id_Autor { get; set; }
        public virtual AutoresModel Autor { get; set; }
    }


}