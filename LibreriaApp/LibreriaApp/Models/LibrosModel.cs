using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations.Schema;
=======
>>>>>>> 764457860f9a075f181c7e5b6fc4fc5c3cc520c4
using System.Linq;
using System.Web;

namespace LibreriaApp.Models
{
    public class LibrosModel
    {
        [Key]
<<<<<<< HEAD
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
=======
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


>>>>>>> 764457860f9a075f181c7e5b6fc4fc5c3cc520c4
}