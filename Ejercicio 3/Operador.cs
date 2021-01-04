using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad9
{
    class Operador
    {
        int num1;
        int num2;



        public Operador()
        {
            num1 = 45;
            num2 = 25;
        }

        public void Suma()
        {
            Console.WriteLine("Suma: {0}",num1+num2);
        }

        public void Resta()
        {
            Console.WriteLine("Resta: {0}", num1 - num2);
        }

        public void Multiplicacion()
        {
            Console.WriteLine("Multiplicacion: {0}", num1 * num2);
        }

        public void Division()
        {
            Console.WriteLine("Division: {0}", num1 / num2);
        }

    }
}
