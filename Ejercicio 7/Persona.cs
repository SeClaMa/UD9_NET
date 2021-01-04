using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad9.Ejercicio_7
{
    class Persona
    {
        private string nombre;
        private int edad;
        private long DNI;
        private char DNIletr;
        private const char sexo = 'H';


        public Persona()
        {

        }

        public Persona(string nombre, int edad, char sexo )
        {
            this.nombre = nombre;
            this.edad = edad;

        }


    }
}
