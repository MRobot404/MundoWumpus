using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoWumpus
{
    public class Casilla
    {
        public bool Wumpus { get; set; }
        public bool Tesoro { get; set; }
        public bool Pozo { get; set; }
        public bool EntradaSalida { get; set; }
        public bool Hedor { get; set; }
        public bool Viento { get; set; }
        public bool Visitada { get; set; }
    }


}
