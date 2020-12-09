using Examen_Final_Calidad.Controllers;
using Examen_Final_Calidad.Models;
using Examen_Final_Calidad.Repositorios;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pruebas_Calidad_Final
{
    class PokerControllerTests
    {
        [Test]
        public void Usuario1Obtiene1Escalera()
        {

            List<Carta> pruebaEscalera = new List<Carta>();
            Carta carta1 = new Carta();
            carta1.Id = 1;
            carta1.Digito = 1;
            carta1.Nombre = "Trebol";
            carta1.IdUser = 1;

            Carta carta2 = new Carta();
            carta2.Id = 2;
            carta2.Digito = 2;
            carta2.Nombre = "Diamante";
            carta2.IdUser = 1;

            Carta carta3 = new Carta();
            carta3.Id = 3;
            carta3.Digito = 3;
            carta3.Nombre = "Trebol";
            carta3.IdUser = 1;

            Carta carta4 = new Carta();
            carta4.Id = 4;
            carta4.Digito = 4;
            carta4.Nombre = "Pica";
            carta4.IdUser = 1;

            Carta carta5 = new Carta();
            carta5.Id = 5;
            carta5.Digito = 5;
            carta5.Nombre = "Corazon";
            carta5.IdUser = 1;

            pruebaEscalera.Add(carta1);
            pruebaEscalera.Add(carta2);
            pruebaEscalera.Add(carta3);
            pruebaEscalera.Add(carta4);
            pruebaEscalera.Add(carta5);

            var pokerMock = new Mock<IPokerRepository>();
            pokerMock.Setup(o => o.ValorMano(pruebaEscalera));

            var pokController = new PokerController(pokerMock.Object);
            var val = pokController.ValorMano(pruebaEscalera);

            Assert.IsInstanceOf<RedirectToActionResult>(val);
        }

        [Test]
        public void Usuario1Obtiene1Poker()
        {

            List<Carta> barajaPrueba = new List<Carta>();
            Carta carta1 = new Carta();
            carta1.Id = 1;
            carta1.Digito = 2;
            carta1.Nombre = "Trebol";
            carta1.IdUser = 1;

            Carta carta2 = new Carta();
            carta2.Id = 2;
            carta2.Digito = 2;
            carta2.Nombre = "Diamante";
            carta2.IdUser = 1;

            Carta carta3 = new Carta();
            carta3.Id = 3;
            carta3.Digito = 2;
            carta3.Nombre = "Trebol";
            carta3.IdUser = 1;

            Carta carta4 = new Carta();
            carta4.Id = 4;
            carta4.Digito = 4;
            carta4.Nombre = "Pica";
            carta4.IdUser = 1;

            Carta carta5 = new Carta();
            carta5.Id = 5;
            carta5.Digito = 2;
            carta5.Nombre = "Corazon";
            carta5.IdUser = 1;

            barajaPrueba.Add(carta1);
            barajaPrueba.Add(carta2);
            barajaPrueba.Add(carta3);
            barajaPrueba.Add(carta4);
            barajaPrueba.Add(carta5);

            var pokerMock = new Mock<IPokerRepository>();
            pokerMock.Setup(o => o.ValorMano(barajaPrueba));

            var pokController = new PokerController(pokerMock.Object);
            var val = pokController.ValorMano(barajaPrueba);

            Assert.IsInstanceOf<RedirectToActionResult>(val);
        }


        [Test]
        public void Usuario1Obtiene1Trio()
        {
            List<Carta> barajaPrueba = new List<Carta>();
            Carta carta1 = new Carta();
            carta1.Id = 1;
            carta1.Digito = 1;
            carta1.Nombre = "Trebol";
            carta1.IdUser = 1;

            Carta carta2 = new Carta();
            carta2.Id = 2;
            carta2.Digito = 2;
            carta2.Nombre = "Diamante";
            carta2.IdUser = 1;

            Carta carta3 = new Carta();
            carta3.Id = 3;
            carta3.Digito = 1;
            carta3.Nombre = "Trebol";
            carta3.IdUser = 1;

            Carta carta4 = new Carta();
            carta4.Id = 4;
            carta4.Digito = 1;
            carta4.Nombre = "Pica";
            carta4.IdUser = 1;

            Carta carta5 = new Carta();
            carta5.Id = 5;
            carta5.Digito = 5;
            carta5.Nombre = "Corazon";
            carta5.IdUser = 1;

            barajaPrueba.Add(carta1);
            barajaPrueba.Add(carta2);
            barajaPrueba.Add(carta3);
            barajaPrueba.Add(carta4);
            barajaPrueba.Add(carta5);

            var pokerMock = new Mock<IPokerRepository>();
            pokerMock.Setup(o => o.ValorMano(barajaPrueba));

            var pokController = new PokerController(pokerMock.Object);
            var val = pokController.ValorMano(barajaPrueba);

            Assert.IsInstanceOf<RedirectToActionResult>(val);
        }

        [Test]
        public void Usuario1Obtiene1Par()
        {
            List<Carta> barajaPrueba = new List<Carta>();
            Carta carta1 = new Carta();
            carta1.Id = 1;
            carta1.Digito = 1;
            carta1.Nombre = "Trebol";
            carta1.IdUser = 1;

            Carta carta2 = new Carta();
            carta2.Id = 2;
            carta2.Digito = 2;
            carta2.Nombre = "Diamante";
            carta2.IdUser = 1;

            Carta carta3 = new Carta();
            carta3.Id = 3;
            carta3.Digito = 1;
            carta3.Nombre = "Trebol";
            carta3.IdUser = 1;

            Carta carta4 = new Carta();
            carta4.Id = 4;
            carta4.Digito = 12;
            carta4.Nombre = "Pica";
            carta4.IdUser = 1;

            Carta carta5 = new Carta();
            carta5.Id = 5;
            carta5.Digito = 5;
            carta5.Nombre = "Corazon";
            carta5.IdUser = 1;

            barajaPrueba.Add(carta1);
            barajaPrueba.Add(carta2);
            barajaPrueba.Add(carta3);
            barajaPrueba.Add(carta4);
            barajaPrueba.Add(carta5);

            var pokerMock = new Mock<IPokerRepository>();
            pokerMock.Setup(o => o.ValorMano(barajaPrueba));

            var pokController = new PokerController(pokerMock.Object);
            var val = pokController.ValorMano(barajaPrueba);

            Assert.IsInstanceOf<RedirectToActionResult>(val);
        }

        [Test]
        public void Usuario1ObtieneDoblePar()
        {
            List<Carta> barajaPrueba = new List<Carta>();
            Carta carta1 = new Carta();
            carta1.Id = 1;
            carta1.Digito = 1;
            carta1.Nombre = "Trebol";
            carta1.IdUser = 1;

            Carta carta2 = new Carta();
            carta2.Id = 2;
            carta2.Digito = 2;
            carta2.Nombre = "Diamante";
            carta2.IdUser = 1;

            Carta carta3 = new Carta();
            carta3.Id = 3;
            carta3.Digito = 1;
            carta3.Nombre = "Trebol";
            carta3.IdUser = 1;

            Carta carta4 = new Carta();
            carta4.Id = 4;
            carta4.Digito = 2;
            carta4.Nombre = "Pica";
            carta4.IdUser = 1;

            Carta carta5 = new Carta();
            carta5.Id = 5;
            carta5.Digito = 5;
            carta5.Nombre = "Corazon";
            carta5.IdUser = 1;

            barajaPrueba.Add(carta1);
            barajaPrueba.Add(carta2);
            barajaPrueba.Add(carta3);
            barajaPrueba.Add(carta4);
            barajaPrueba.Add(carta5);

            var pokerMock = new Mock<IPokerRepository>();
            pokerMock.Setup(o => o.ValorMano(barajaPrueba));

            var pokController = new PokerController(pokerMock.Object);
            var val = pokController.ValorMano(barajaPrueba);

            Assert.IsInstanceOf<RedirectToActionResult>(val);
        }

        [Test]
        public void Usuario1Obtiene1Trio1Par()
        {
            List<Carta> barajaPrueba = new List<Carta>();
            Carta carta1 = new Carta();
            carta1.Id = 1;
            carta1.Digito = 1;
            carta1.Nombre = "Trebol";
            carta1.IdUser = 1;

            Carta carta2 = new Carta();
            carta2.Id = 2;
            carta2.Digito = 2;
            carta2.Nombre = "Diamante";
            carta2.IdUser = 1;

            Carta carta3 = new Carta();
            carta3.Id = 3;
            carta3.Digito = 1;
            carta3.Nombre = "Trebol";
            carta3.IdUser = 1;

            Carta carta4 = new Carta();
            carta4.Id = 4;
            carta4.Digito = 2;
            carta4.Nombre = "Pica";
            carta4.IdUser = 1;

            Carta carta5 = new Carta();
            carta5.Id = 5;
            carta5.Digito = 1;
            carta5.Nombre = "Corazon";
            carta5.IdUser = 1;

            barajaPrueba.Add(carta1);
            barajaPrueba.Add(carta2);
            barajaPrueba.Add(carta3);
            barajaPrueba.Add(carta4);
            barajaPrueba.Add(carta5);

            var pokerMock = new Mock<IPokerRepository>();
            pokerMock.Setup(o => o.ValorMano(barajaPrueba));

            var pokController = new PokerController(pokerMock.Object);
            var val = pokController.ValorMano(barajaPrueba);

            Assert.IsInstanceOf<RedirectToActionResult>(val);
        }

        [Test]
        public void Usuario2Obtiene1Trio1Par()
        {
            List<Carta> barajaPrueba = new List<Carta>();
            Carta carta1 = new Carta();
            carta1.Id = 1;
            carta1.Digito = 1;
            carta1.Nombre = "Trebol";
            carta1.IdUser = 2;

            Carta carta2 = new Carta();
            carta2.Id = 2;
            carta2.Digito = 2;
            carta2.Nombre = "Diamante";
            carta2.IdUser = 2;

            Carta carta3 = new Carta();
            carta3.Id = 3;
            carta3.Digito = 1;
            carta3.Nombre = "Trebol";
            carta3.IdUser = 2;

            Carta carta4 = new Carta();
            carta4.Id = 4;
            carta4.Digito = 2;
            carta4.Nombre = "Pica";
            carta4.IdUser = 2;

            Carta carta5 = new Carta();
            carta5.Id = 5;
            carta5.Digito = 1;
            carta5.Nombre = "Corazon";
            carta5.IdUser = 2;

            barajaPrueba.Add(carta1);
            barajaPrueba.Add(carta2);
            barajaPrueba.Add(carta3);
            barajaPrueba.Add(carta4);
            barajaPrueba.Add(carta5);

            var pokerMock = new Mock<IPokerRepository>();
            pokerMock.Setup(o => o.ValorMano(barajaPrueba));

            var pokController = new PokerController(pokerMock.Object);
            var val = pokController.ValorMano(barajaPrueba);

            Assert.IsInstanceOf<RedirectToActionResult>(val);
        }

        [Test]
        public void Usuario2Obtiene1Escalera()
        {
            List<Carta> barajaPrueba = new List<Carta>();
            Carta carta1 = new Carta();
            carta1.Id = 1;
            carta1.Digito = 1;
            carta1.Nombre = "Trebol";
            carta1.IdUser = 2;

            Carta carta2 = new Carta();
            carta2.Id = 2;
            carta2.Digito = 2;
            carta2.Nombre = "Diamante";
            carta2.IdUser = 2;

            Carta carta3 = new Carta();
            carta3.Id = 3;
            carta3.Digito = 3;
            carta3.Nombre = "Trebol";
            carta3.IdUser = 2;

            Carta carta4 = new Carta();
            carta4.Id = 4;
            carta4.Digito = 4;
            carta4.Nombre = "Pica";
            carta4.IdUser = 2;

            Carta carta5 = new Carta();
            carta5.Id = 5;
            carta5.Digito = 5;
            carta5.Nombre = "Corazon";
            carta5.IdUser = 2;

            barajaPrueba.Add(carta1);
            barajaPrueba.Add(carta2);
            barajaPrueba.Add(carta3);
            barajaPrueba.Add(carta4);
            barajaPrueba.Add(carta5);

            var pokerMock = new Mock<IPokerRepository>();
            pokerMock.Setup(o => o.ValorMano(barajaPrueba));

            var pokController = new PokerController(pokerMock.Object);
            var val = pokController.ValorMano(barajaPrueba);

            Assert.IsInstanceOf<RedirectToActionResult>(val);
        }


        [Test]
        public void Usuario2Obtiene1Trio()
        {
            List<Carta> barajaPrueba = new List<Carta>();
            Carta carta1 = new Carta();
            carta1.Id = 1;
            carta1.Digito = 1;
            carta1.Nombre = "Trebol";
            carta1.IdUser = 2;

            Carta carta2 = new Carta();
            carta2.Id = 2;
            carta2.Digito = 4;
            carta2.Nombre = "Diamante";
            carta2.IdUser = 2;

            Carta carta3 = new Carta();
            carta3.Id = 3;
            carta3.Digito = 1;
            carta3.Nombre = "Trebol";
            carta3.IdUser = 2;

            Carta carta4 = new Carta();
            carta4.Id = 4;
            carta4.Digito = 2;
            carta4.Nombre = "Pica";
            carta4.IdUser = 2;

            Carta carta5 = new Carta();
            carta5.Id = 5;
            carta5.Digito = 1;
            carta5.Nombre = "Corazon";
            carta5.IdUser = 2;

            barajaPrueba.Add(carta1);
            barajaPrueba.Add(carta2);
            barajaPrueba.Add(carta3);
            barajaPrueba.Add(carta4);
            barajaPrueba.Add(carta5);

            var pokerMock = new Mock<IPokerRepository>();
            pokerMock.Setup(o => o.ValorMano(barajaPrueba));

            var pokController = new PokerController(pokerMock.Object);
            var val = pokController.ValorMano(barajaPrueba);

            Assert.IsInstanceOf<RedirectToActionResult>(val);
        }
    }
}
