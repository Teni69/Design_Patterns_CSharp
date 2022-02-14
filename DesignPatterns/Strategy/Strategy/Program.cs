using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Kacsa;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KonkretKacsa kacsa1 = new KonkretKacsa(new Hangos(), new GyorsanRepul());
            AbstractKacsa kacsa2 = new KonkretKacsa(new Hangos(), new NemRepul());
            kacsa1.Repul();
            kacsa1.Hapogas();
            kacsa2.Repul();
            kacsa2.Hapogas();
            Console.ReadLine();
        }
    }
}
