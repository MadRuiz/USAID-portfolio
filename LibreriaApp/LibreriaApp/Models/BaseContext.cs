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
    }
}