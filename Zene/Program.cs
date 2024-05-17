using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zene
{
    //static vs dynamic: előbbi példányosítás nélkül használható, utóbbi csak példányosítás után
    internal class Program
    {
        static void Main(string[] args)
        {
            EloadokElemzese(); //mert static
            (new Program()).CimekElemzese(); //mert dinamikus
        }

        static void EloadokElemzese()
        {
            foreach (string sor in File.ReadAllLines("zenek.txt"))
            {

                //3 4 32 Deep Purple:Living wreck
                string[] reszek = sor.Split(':');
                //reszek[0] 3 4 32 Deep Purple
                //reszek[1] Living wreck
                reszek = reszek[0].Split(':'); //az egyenlőség jobb oldala a jelen, bal pedig a jövő
                string eloado = reszek[3];
                for(int i = 4; i < reszek.Length; i++)
                {
                    eloado += (' ' + reszek[i]);
                }
                Console.WriteLine(eloado);
            }
        }

        void CimekElemzese()
        {

        }
    }
}
