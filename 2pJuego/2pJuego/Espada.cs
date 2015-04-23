using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2pJuego
{
    class Espada: Armas
    {
        public string x;
       Espada espada = new Espada();
     //  new Espada espada();
       public Espada()
       { }
        public Espada(string x)
        {
            x += " fuerza 10, corte 9, provoca hemorragia! ";
        }
        
        
        public override string ToString()
        {
            return x;
        }
    }
}
