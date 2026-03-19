using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Libro
    {
        private string titulo { get; set; }
        private string autor { get; set;  }
        private int anio { get; set; }
        private string estado { get; set; }
        public Libro(string titulo_, string autor_, int anio_, string estado_= "disponible")
        {
            string[] estados = { "disponible", "prestado" };
            titulo = titulo_;
            autor = autor_;
            anio = anio_;
            estado = estados.Contains(estado_.ToLower()) ? estado_ : estados[0];

        }
    }
}
