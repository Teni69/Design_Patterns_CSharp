using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class GyorsanRepul : IRepulesStrategia
    {
        public void Repul()
        {
            Console.WriteLine("Gyorsan Repül");
        }
    }
}
