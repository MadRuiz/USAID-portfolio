using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginApp.Models
{
    public class PersonasModel
    {
        public int CalcularEdad(int bornDate)
        {
           
            var currentDate = DateTime.Now.Year;

            var edad = currentDate - bornDate;

            return edad;
        }

        
    }
}