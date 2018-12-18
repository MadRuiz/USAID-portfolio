using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace LoginApp.Models
{
    public class TablasModel
    {

        public List<string> Calcular(int a)
        {
            List<string> tabla = new List<string>();
            int vueltas = 1;
            while (vueltas <= 10)
            {
                string cadena;
                cadena = a + " x " + vueltas + " = " + (a * vueltas);
                tabla.Add(cadena);
                vueltas += 1;
            }
            return tabla;
        }
    }
}