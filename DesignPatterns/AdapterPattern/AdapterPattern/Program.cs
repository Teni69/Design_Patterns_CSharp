using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Csinálunk egy új robotot, majd becsomagoljuk egy Robot2Ember példányba
            // Ezáltal már emberként is használhatjuk, nem csak robotként, mert a robot2ember az egy ember
            Robot R2D2 = new Robot("R2D2", 90000);
            Ember R2D2wrapper = new Robot2Ember(R2D2);
            Console.WriteLine("Neve: {0}", R2D2wrapper.GetNév());
            Console.WriteLine("IQ-ja: {0}", R2D2wrapper.GetIQ());
            Console.ReadKey();
        }
    }
    //Van egy ember osztályunk, erre akarjuk illeszteni a robotot
    abstract class Ember
    {
        public abstract string GetNév();
        public abstract int GetIQ();
    }

    //Adaptee, illesztendő
    class Robot
    {
        string ID;
        int memory;

        public Robot(string ID, int memory)
        {
            this.ID = ID;
            this.memory = memory;
        }
        public string GetID() { return ID; }
        public int GetMemory() { return memory; }
    }

    //Ez lesz az adapter, a robotot felületét átalakítja az emberévé
    class Robot2Ember : Ember
    {
        Robot robi;
        public Robot2Ember(Robot robi) { this.robi = robi; }

        public override string GetNév()
        {
            return robi.GetID();
        }

        public override int GetIQ()
        {
            return robi.GetMemory() / 1024; //1GB memória = 1 IQ
        }
    }
}
