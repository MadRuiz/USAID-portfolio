using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoginApp.Models;
using System.Data.Entity;


namespace LoginApp.Models
{
    public class BaseContext : DbContext
    {
        public BaseContext() : base("Model1") { }

        public DbSet<UsuariosModel> Usuarios { get; set; }
    }
}