using Examen_Final_Calidad.Models;
using Examen_Final_Calidad.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_Final_Calidad.Controllers
{
    public class PokerController : Controller
    {

        private readonly IPokerRepository _poker;

        public PokerController(IPokerRepository _poker)
        {
            this._poker = _poker;
        }
        public IActionResult Index()
        {
            var baraja = _poker.CrearBarajaCarta();

            int puntaje1 = 0, puntaje2 = 0, puntaje3 = 0, puntaje4 = 0, puntaje5 = 0;
 
            var barJuga = BarajaDeJugador();

            var manoJugador1 = barJuga.Where(o => o.IdUser == 1).ToList();
            var manoJugador2 = barJuga.Where(o => o.IdUser == 2).ToList();
            var manoJugador3 = barJuga.Where(o => o.IdUser == 3).ToList();
            var manoJugador4 = barJuga.Where(o => o.IdUser == 4).ToList();
            var manoJugador5 = barJuga.Where(o => o.IdUser == 5).ToList();

            ViewBag.user1 = manoJugador1;
            ViewBag.user2 = manoJugador2;
            ViewBag.user3 = manoJugador3;
            ViewBag.user4 = manoJugador4;
            ViewBag.user5 = manoJugador5;

            var valorJugador1 = ValorMano(manoJugador1);
            for (int cont1 = 0; cont1 < valorJugador1.Count; cont1++)
            {
                puntaje1 = valorJugador1[5];
            }

            var valorJugador2 = ValorMano(manoJugador2);
            for (int cont2 = 0; cont2 < valorJugador2.Count; cont2++)
            {
                puntaje2 = valorJugador2[5];
            }

            var valorJugador3 = ValorMano(manoJugador3);
            for (int cont3 = 0; cont3 < valorJugador3.Count; cont3++)
            {
                puntaje3 = valorJugador3[5];
            }

            var valorJugador4 = ValorMano(manoJugador4);
            for (int cont4 = 0; cont4 < valorJugador4.Count; cont4++)
            {
                puntaje4 = valorJugador4[5];
            }

            var valorJugador5 = ValorMano(manoJugador5);
            for (int cont5 = 0; cont5 < valorJugador5.Count; cont5++)
            {
                puntaje5 = valorJugador5[5];
            }

            List<int> valors = new List<int>();
            valors.Add(puntaje1);
            valors.Add(puntaje2);
            valors.Add(puntaje3);
            valors.Add(puntaje4);
            valors.Add(puntaje5);
            var puntMayor = valors.Max();

            int punt40 = 0, punt50 = 0, punt30 = 0, punt25 = 0, punt35 = 0, punt20 = 0, punt10 = 0;

            string mensajeMostrar = null;

            for (int i = 0; i < valors.Count(); i++)
            {
                if (valors[i] == 50)
                {
                    punt50++;
                }

                if (valors[i] == 40)
                {
                    punt40++;
                }

                if (valors[i] == 30)
                {
                    punt30++;
                }

                if (valors[i] == 20)
                {
                    punt20++;
                }

                if (valors[i] == 10)
                {
                    punt10++;
                }

                if (valors[i] == 25)
                {
                    punt25++;
                }

                if (valors[i] == 35)
                {
                    punt35++;
                }
            }

            if(punt50 == 1 || punt40 == 1 || punt30 == 1 || punt20 == 1 || punt10 == 1 || punt25 == 1 || punt35 == 1)
            {
                mensajeMostrar = "Este puntaje es el ganador";
            }else if(punt50 > 1 || punt40 > 1 || punt30 > 1 || punt20 > 1 || punt10 > 1 || punt25 > 1 || punt35 > 1)
            {
                mensajeMostrar = "Existe un empate";
            }
            ViewBag.puntajeMayor = puntMayor;
            ViewBag.mensaje = mensajeMostrar;

            ViewBag.mano1 = ValorMano(manoJugador1);
            ViewBag.mano2 = ValorMano(manoJugador2);
            ViewBag.mano3 = ValorMano(manoJugador3);
            ViewBag.mano4 = ValorMano(manoJugador4);
            ViewBag.mano5 = ValorMano(manoJugador5);
            return View(baraja);
        }

        public List<Carta> CrearBarajaCarta()
        {
            return _poker.CrearBarajaCarta();
        }


        public List<Carta> BarajaDeJugador()
        {

            return _poker.BarajaDeJugador();

        }

        public List<int> ValorMano(List<Carta> cartasJugador)
        {
            return _poker.ValorMano(cartasJugador);

        }


    }
}
