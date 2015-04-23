using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2pJuego
{
    class Personaje
    {
        private string nombre;

        public Personaje()
        {
        }

        public Personaje(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return getNombre() + " ";
        }


    }
}
