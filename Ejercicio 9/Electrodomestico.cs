using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad9
{
    class Electrodomestico
    {
        public int precio_base { get; set; } = 100;
        public string color { get; set; } = "blanco";
        public char consumo_Elec { get; set; } = 'F';
        public int peso { get; set; } = 5;

        public Electrodomestico()
        {

        }

        public Electrodomestico(int precio_base, int peso)
        {
            this.precio_base = precio_base;
            this.peso = peso;
        }

        public Electrodomestico(int precio_base, string color, char consumo_Elec, int peso)
        {
            this.precio_base = precio_base;
            this.color = color;
            this.consumo_Elec = consumo_Elec;
            this.peso = peso;
        }

        public void Imprimir()
        {
            Console.WriteLine("Precio: {0}, Color: {1}, Consumo: {2}, Peso: {3}",precio_base,color,consumo_Elec,peso);
        }


    }
}
