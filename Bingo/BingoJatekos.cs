using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    class BingoJatekos
    {
        public string Nev { get; private set; }
        public int[,] Kartya { get; private set; }

        public BingoJatekos(string nev, int[,] kartya)
        {
            Nev = nev;
            Kartya = kartya;
        }
    }
}
