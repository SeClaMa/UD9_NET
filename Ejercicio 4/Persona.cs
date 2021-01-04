using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad9
{
    class Persona
    {
        private String nombre;

        public void SetNombre (string nombre)
        {
            this.nombre = nombre;

        }

        public void Saludar()
        {
            Console.WriteLine("Hola {0}", nombre);
        }



    }
}
