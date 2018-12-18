using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginApp.Models
{
    public class UsuariosModel
    {
        [Key]
        public int IdLogin { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]

        [Display(Name = "Nombre Completo")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Este campo debe llevar formato de correo electrónico")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Pass { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [Compare("Pass", ErrorMessage = "Las contraseñas no coinciden")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contraseña")]
        public string ConfirmPass { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [DataType(DataType.Text)]
        public string Rol { get; set; }

        [DataType(DataType.MultilineText)]
        public string Descripcion { get; set; }
    }
}