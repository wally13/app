using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2pJuego
{
    class Armas
    {
        private string armas;

         public Armas() { }

        public Armas(string armas)
        {
            this.armas = armas;
        }

        public string getArmas()
        {
            return armas;
        }

        public void setArmas(string armas)
        {
            this.armas = armas;
        }


        public override string ToString()
        {
            return getArmas();
        }

        }
    }

