using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    internal class ConcreteObserver : IObserver, IDisplay
    {
        private float temperature;
        private IObservable observable;

        public ConcreteObserver(IObservable o)
        {
            this.observable = o;
            observable.addObserver(this);
        }

        public void Update(float temp)
        {
            temperature = temp;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Jelenlegi hőmérséklet: "+temperature);
        }
    }
}
