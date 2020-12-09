using Examen_Final_Calidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_Final_Calidad.Repositorios
{
    public interface IPokerRepository
    {
        List<string> nombreCarta();
        List<Carta> CrearBarajaCarta();
        List<Carta> BarajaDeJugador();

        int Valores();
        List<int> ValorMano(List<Carta> cartasJugador);
    }



    public class PokerRepository : IPokerRepository
    {
        public List<string> nombreCarta()
        {
            List<string> nomb = new List<string>();
            nomb.Add("Trebol");
            nomb.Add("Pica");
            nomb.Add("Corazon");
            nomb.Add("Diamante");
            return nomb;
        }

        public List<Carta> CrearBarajaCarta()
        {
            List<Carta> baraja = new List<Carta>();
            int numCar = 1;
            int nombreCar = 0;

            var tipoC = nombreCarta();
            for (int i = 1; i <= 52; i++)
            {

                Carta car = new Carta();

                if (numCar > 13)
                {
                    numCar = 1;
                    nombreCar++;

                }
                car.Id = i;
                car.Digito = numCar;
                car.Nombre = tipoC[nombreCar];
                numCar++;
                baraja.Add(car);

            }
            return baraja;
        }

        public List<Carta> BarajaDeJugador()
        {
            var baraj = CrearBarajaCarta();

            List<int> indJugadores = new List<int>();
            Random barajear = new Random();
            int contNum = 1;

            for (int i = 1; i <= 5; i++)
            {
                do
                {
                    var numBarajeado = barajear.Next(0, 52);

                    if (!indJugadores.Contains(numBarajeado))
                    {
                        indJugadores.Add(numBarajeado);
                        baraj[numBarajeado].IdUser = i;
                        contNum++;
                    }
                } while (contNum <= 5);

                contNum = 1;
            }

            return baraj;

        }

        public List<int> ValorMano(List<Carta> cartasJugador)
        {
            int dig1 = 0, dig2 = 0, dig3 = 0, dig4 = 0, dig5 = 0, dig6 = 0, dig7 = 0, dig8 = 0,
                dig9 = 0, dig10 = 0, dig11 = 0, dig12 = 0, dig13 = 0;

            int cartTrebol = 0, cartPica = 0, cartDiamante = 0, cartCorazon = 0;

            int numConsecutivos = 0, escalera = 0, poker = 0, trio = 0, par = 0, doblePar = 0, sinPar = 0, puntaje = 0;

            for (int i = 0; i < cartasJugador.Count(); i++)
            {
                if (cartasJugador[i].Digito == 1)
                {
                    dig1++;
                }
                if (cartasJugador[i].Digito == 2)
                {
                    dig2++;
                }
                if (cartasJugador[i].Digito == 3)
                {
                    dig3++;
                }
                if (cartasJugador[i].Digito == 4)
                {
                    dig4++;
                }
                if (cartasJugador[i].Digito == 5)
                {
                    dig5++;
                }
                if (cartasJugador[i].Digito == 6)
                {
                    dig6++;
                }
                if (cartasJugador[i].Digito == 7)
                {
                    dig7++;
                }
                if (cartasJugador[i].Digito == 8)
                {
                    dig8++;
                }
                if (cartasJugador[i].Digito == 9)
                {
                    dig9++;
                }
                if (cartasJugador[i].Digito == 10)
                {
                    dig10++;
                }
                if (cartasJugador[i].Digito == 11)
                {
                    dig11++;
                }
                if (cartasJugador[i].Digito == 12)
                {
                    dig12++;
                }
                if (cartasJugador[i].Digito == 13)
                {
                    dig13++;
                }



                if (cartasJugador[i].Nombre == "Trebol")
                {
                    cartTrebol++;
                }
                else if (cartasJugador[i].Nombre == "Pica")
                {
                    cartPica++;
                }
                if (cartasJugador[i].Nombre == "Corazon")
                {
                    cartCorazon++;
                }
                if (cartasJugador[i].Nombre == "Diamante")
                {
                    cartDiamante++;

                }

                if (i == 0)
                {
                    if (cartasJugador[i + 1].Digito - cartasJugador[i].Digito == 1)
                    {
                        numConsecutivos++;
                    }
                }
                else
                {
                    if (cartasJugador[i].Digito - cartasJugador[i - 1].Digito == 1)
                    {
                        numConsecutivos++;
                    }
                }


                if (numConsecutivos == 5)
                {
                    escalera++;
                }

            }



            List<int> valores = new List<int>();
            valores.Add(dig1);
            valores.Add(dig2);
            valores.Add(dig3);
            valores.Add(dig4);
            valores.Add(dig5);
            valores.Add(dig6);
            valores.Add(dig7);
            valores.Add(dig8);
            valores.Add(dig9);
            valores.Add(dig10);
            valores.Add(dig11);
            valores.Add(dig12);
            valores.Add(dig13);

            List<int> misValores = new List<int>();
            for (int j = 0; j < valores.Count(); j++)
            {
                if (valores[j] > 0)
                {
                    misValores.Add(valores[j]);
                }
            }

            for (int k = 0; k < misValores.Count(); k++)
            {
                if (misValores[k] == 4)
                {
                    poker++;
                }
                else if (misValores[k] == 3)
                {
                    trio++;
                }
                else if (misValores[k] == 2)
                {
                    par++;
                }
                else
                {
                    sinPar++;
                }

                if (par == 2)
                {
                    doblePar = 1;
                }



                if (escalera == 1)
                {
                    puntaje = 50;
                }
                else
                if (poker == 1)
                {
                    puntaje = 40;
                }
                else
                if (trio == 1)
                {
                    puntaje = 30;
                }
                else
                if (par == 1)
                {
                    puntaje = 20;
                }
                else
                if (doblePar == 1)
                {
                    puntaje = 25;
                }
                else
                if (trio == 1 && par == 1)
                {
                    puntaje = 35;
                }
                else
                {
                    puntaje = 10;
                }


            }
            List<int> nombresManos = new List<int>();
            nombresManos.Add(par);
            nombresManos.Add(doblePar);
            nombresManos.Add(trio);
            nombresManos.Add(poker);
            nombresManos.Add(escalera);
            nombresManos.Add(puntaje);

            return nombresManos;

        }

        public int Valores()
        {
            return 1;
        }
    }
}
