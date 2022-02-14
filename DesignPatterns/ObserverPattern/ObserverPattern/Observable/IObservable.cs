using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal interface IObservable
    {
        void Notify();
        void addObserver(IObserver O);
        void removeObserver(IObserver O);
    }
}
