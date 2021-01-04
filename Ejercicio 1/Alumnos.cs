using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Proyecto_Unidad9
{
    class Alumnos
    {
         int edad;
         string nombre;
        
        public Alumnos()
        {
            edad = 19;
            nombre = "Fernando";
        }
  

        public void ImprimirAlumno()
        {
            Console.WriteLine("Alumno {0} con edad {1}",nombre,edad);
        }

        public void ComprobarEdad()
        {
            if (edad >= 18)
            {
                Console.WriteLine("El alumno {0} es mayor de edad", nombre);
            }
            else
            {
                Console.WriteLine("No es mayor de edad");
            }
            {

            }
        }

    }
}
