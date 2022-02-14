using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observable
{
    internal class ConcreteObservable : IObservable
    {
        private List<IObserver> observers;
        private float temperature;

        public ConcreteObservable()
        {
            observers = new List<IObserver>();
        }

        public void addObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void Notify()
        {
            foreach (IObserver o in observers)
            {
                o.Update(temperature);
            }
        }

        public void TempChanged()
        {
            Notify();
        }

        public void SetTemp(float temp)
        {
            this.temperature = temp;
            TempChanged();
        }
    }
}
