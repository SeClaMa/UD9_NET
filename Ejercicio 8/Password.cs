using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad9
{
    class Password
    {
        public int longitud = 8;
        public string contra;

        public Password()
        {

        }

        public Password(int longi, string cont)
        {
            this.longitud = longi;
            this.contra = cont;

            Console.WriteLine("Modifique la longitud: ");
            longi = Convert.ToInt32(Console.ReadLine());

            Guid miGuid = Guid.NewGuid();
            cont = Convert.ToBase64String(miGuid.ToByteArray());
            cont = cont.Replace("=", "").Replace("+", "");
            Console.WriteLine(cont.Substring(0, longi));

        }


    }
}
