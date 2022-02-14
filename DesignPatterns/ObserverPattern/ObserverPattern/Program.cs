using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Observer;
using ObserverPattern.Observable;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteObservable alany = new ConcreteObservable();
            ConcreteObserver megfigyelo1 = new ConcreteObserver(alany);
            ConcreteObserver megfigyelo2 = new ConcreteObserver(alany); //Létrehozzuk, feliratkoztatjuk

            alany.SetTemp(32);
            alany.SetTemp(12);
            Console.WriteLine();
            alany.removeObserver(megfigyelo1); //Leiratkoztatjuk
            alany.SetTemp(60); //Csak a feliratkozottat értesíti, a másodikat
            Console.ReadKey();
        }
    }
}
