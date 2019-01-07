using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LibreriaApp.Models
{
    public class LibrosModel
    {
        [Key]
        public int Id_Libro { get; set; }
        [Display (Name = "Libro")]
        public string Nombre { get; set; }
        [Display(Name = "Páginas")]
        public int Paginas { get; set; }
        [Display(Name = "Descripción")]
        public int Descripcion { get; set; }

        [ForeignKey("Autor")]
        public int Id_Autor { get; set; }
        public AutoresModel Autor { get; set; }
    }
}