using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibreriaApp.Models;
using System.Data.Entity;

namespace LibreriaApp.Models
{
    public class BaseContext : DbContext
    {
        public DbSet<AutoresModel> Autores { get; set; }
        public DbSet<LibrosModel> Libros { get; set; }
<<<<<<< HEAD
=======
        
>>>>>>> 764457860f9a075f181c7e5b6fc4fc5c3cc520c4
    }
}