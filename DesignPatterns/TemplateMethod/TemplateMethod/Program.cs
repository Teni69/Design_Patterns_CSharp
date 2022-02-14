using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ital kave = new Tea();
            Ital tea = new Kávé();
            tea.Elkeszit();
            kave.Elkeszit();
            Console.ReadKey();
        }
    }

    public abstract class Ital
    {
        public void Elkeszit()
        {
            vizforralo();
            foz();
            edesit();
            rum();
            kitolt();
        }
        private void vizforralo() //Kötelező, közös
        {
            Console.WriteLine("Vízforralás");
        }
        protected abstract void edesit(); //Kötelező nem közös, kidolgozandó
        protected abstract void foz(); //Kötelező, nem közös

        protected virtual void rum() { } //Opcionális

        private  void kitolt() //Kötelező, közös
        {
            Console.WriteLine("Kitöltés\n");
        }
    }

    public class Tea : Ital
    {
        protected override void edesit()
        {
            Console.WriteLine("Cukrot teszek a teába");
        }

        protected override void foz()
        {
            Console.WriteLine("Teafilter");
        }
    }

    public class Kávé : Ital
    {
        protected override void edesit()
        {
            Console.WriteLine("Édesítőszert teszek bele");
        }

        protected override void foz()
        {
            Console.WriteLine("Leforrázom a kávét");
        }

        protected override void rum()
        {
            Console.WriteLine("Rumot teszek a kávéba");
        }
    }
}
