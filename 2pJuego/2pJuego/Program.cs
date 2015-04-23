using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2pJuego
{
    class Program
    {
        static void Main(string[] args)
        {
            int resp;
            string aux, aux2;

            Personaje[] personaje = new Personaje[5];
            Armas[] armas = new Armas[5];

            //Personaje[] personaje = new Personaje[5];
            //Armas [] armas = new Armas[5];
             
            string a = "Llave Inglesa";
            string b = "Espada Maestra";
            string c = "Brazo Laser";
            string d = "Estrella Ninja";
            string e = "Arma Laser";
            armas[0] = new Armas(a);
            armas[1] = new Armas(b);
            armas[2] = new Armas(c);
            armas[3] = new Armas(d);
            armas[4] = new Armas(e);

            string aa = "Mario Bros.";
            string bb = "Link";
            string cc = "Seamus";
            string dd = "Kirby";
            string ee = "Starfox";
            personaje[0] = new Personaje(aa);
            personaje[1] = new Personaje(bb);
            personaje[2] = new Personaje(cc);
            personaje[3] = new Personaje(dd);
            personaje[4] = new Personaje(ee);

            Personaje perso = new Personaje();
            Armas arma = new Espada();

            for (int i = 0; i < personaje.Length; i++)
            {
                Console.WriteLine("Selecciona: " + (i+1) + " Para: " + personaje[i].ToString());
            }

            Console.WriteLine("Seleccione un personaje: ");
            resp = int.Parse(Console.ReadLine());
            //aux = armas[resp-1].ToString();
            aux2 = personaje[resp-1].ToString();


             if (resp > 0 || resp < 5)
                {
                        arma.setArmas("Espada");
                        perso.setNombre(aux2);
                        Console.WriteLine("el personaje del juego que eligio fue " + perso.getNombre() + " " + " \n su arma principal es: " + arma.getArmas()
                            + " los atributos de su arma son: " + arma.ToString());
                        Console.ReadLine();
                        
                }
                else
                {
                    Console.WriteLine("Error... opcion no valida!!!");
                }
          }
        }
    }

