using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_Final_Calidad.Models
{
    public class Carta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Digito { get; set; }

        public int IdUser { get; set; }
    }
}
