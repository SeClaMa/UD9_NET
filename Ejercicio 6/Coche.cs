using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad9
{
    class Coche
    {
        private string marca;
        private string modelo;
        private int cilindrada;
        private double potencia;

        public string CocheMarca(string marca)
        {
            this.marca = marca;
            return marca;
        }

        public string CocheModelo(string modelo)
        {
            this.modelo = modelo;
            return modelo;
        }

        public int CocheCilidrada(int cilindrada)
        {
            this.cilindrada = cilindrada;
            return cilindrada;
        }

        public double CochePotencia(double potencia)
        {
            this.potencia = potencia;
            return potencia;
        }


    }
}
