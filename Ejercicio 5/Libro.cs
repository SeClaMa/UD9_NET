using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad9
{
    class Libro
    {
        private string autor;

        private string titulo;

        private string ubicacion;

        public string LibroAutor(string autor)
        {         
                this.autor = autor;
                return autor;

        }
        public string LibroTitulo(string titulo)
        {
            this.titulo = titulo;
            return titulo;

        }
        public string LibroUbicacion(string ubicacion)
        {
            this.ubicacion = ubicacion;
            return ubicacion;

        }

                    
                


    }
}
