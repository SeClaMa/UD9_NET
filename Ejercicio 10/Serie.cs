using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad9
{
    class Serie
    {
        public string titulo { get; set; }
        public int NumTemp { get; set; } = 3;

        public bool entregado { get; set; } = false;

        public string genero { get; set; }

        public string creador { get; set; }

        public Serie()
        {

        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
      
        }

        public Serie(string titulo, int NumTemp, string genero, string creador)
        {
            this.titulo = titulo;
            this.NumTemp = NumTemp;
            this.genero = genero;
            this.creador = creador;
            
        }


    }
}
