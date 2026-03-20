using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Libro
    {
        public string titulo { get; set; }
        public string autor { get; set; }
        public int anio { get; set; }
        public string estado { get; set; }
        public Libro(string titulo_, string autor_, int anio_, string estado_ = "disponible")
        {
            string[] estados = { "disponible", "prestado" };
            titulo = titulo_;
            autor = autor_;
            anio = anio_;
            estado = estados.Contains(estado_.ToLower()) ? estado_ : estados[0];

        }


    }
}
