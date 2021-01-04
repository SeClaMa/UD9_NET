using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad9
{
    class Empleado
    {
        string nombre;
        int sueldo;

        public Empleado()
        {
            nombre = "Rafa";
            sueldo = 3200;
        }

        public void ImprimirEmpleado()
        {
            Console.WriteLine("El empleado {0} tiene un sueldo de {1} EUR",nombre,sueldo);
        }

        public void PagarImpuestos()
        {
            if (sueldo >= 3000)
            {
                Console.WriteLine("{0} debe pagar impuestos",nombre);
            }
            else
            {
                Console.WriteLine("No debe pagar impuestos");
            }
        }

    }
}
