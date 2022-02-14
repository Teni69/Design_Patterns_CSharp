using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinositesGyar[] minosito = new MinositesGyar[2];
            minosito[0] = new AMinositesGyar();
            minosito[1] = new BMinositesGyar();
            foreach(MinositesGyar m in minosito)
            {
                Minosites minosites = m.CreateMinosites();
                minosites.Minosit();
            }
            Console.ReadKey();
        }
    }

    interface Minosites
    {
        void Minosit();
    }
    class A_Minosites : Minosites
    {
        public void Minosit() { Console.WriteLine("A minősítés!"); }
    }
    class B_Minosites : Minosites
    {
        public void Minosit() { Console.WriteLine("B minősítés!"); }
    }

    //A gyermek osztály fogja eldönteni hogy mit gyárt
    abstract class MinositesGyar
    {
        public Minosites CreateMinosites()
        {
            return Minosit();
        }
        public abstract Minosites Minosit();
    }

    //gyárt egy A_Minositést
    class AMinositesGyar : MinositesGyar
    {
        public override Minosites Minosit()
        {
            return new A_Minosites();
        }
    }

    //gyárt egy B_Minositést
    class BMinositesGyar : MinositesGyar
    {
        public override Minosites Minosit()
        {
            return new B_Minosites();
        }
    }
}
