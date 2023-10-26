using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bingo
{
    class Program
    {
        static List<BingoJatekos> jatekosok;
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"..\..\src");
            jatekosok = InitJatekosok(@"..\..\src");
            //Console.WriteLine(jatekosok.Count);
            Console.ReadKey();


        }

        private static List<BingoJatekos> InitJatekosok(string path)
        {
            var lista = new List<BingoJatekos>();
            string[] fileok = Directory.GetFiles(path);
            foreach (var file in fileok)
            {
                if (file.Contains(".txt"))
                {
                    using (var sr = new StreamReader(file))
                    {
                        var nev = file.Split('\\')[3].Split('.')[0];
                        int[,] kartya = new int[5, 5];
                        int si = 0;
                        while (!sr.EndOfStream)
                        {
                            string[] s = sr.ReadLine().Split(';');
                            int oi = 0;
                            foreach (var szam in s)
                            {
                                if (szam != "X") kartya[si, oi] = int.Parse(szam);
                                oi++;
                            }
                            si++;
                        }
                        lista.Add(new BingoJatekos(nev, kartya));
                    }

                }
            }
            return lista;
        }
    }
}
