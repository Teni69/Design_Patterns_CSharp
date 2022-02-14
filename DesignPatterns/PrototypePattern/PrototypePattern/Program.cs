using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A prototípusokat klónozom, ergo ezekből lesz több
            Gepkocsi prototype1 = new VersenyAuto("Lamborghini", 2, 320);
            Gepkocsi prototype2 = new TeherAuto("Ifa", 3, 5000);

            //Új gyár
            Gyar gyartosor = new Gyar();

            //5 zöld Gépkocsit klónozzon a lamborghiniből
            Gepkocsi[] vk = gyartosor.sorozatGyartas(prototype1, "Zöld", 5);
            foreach (VersenyAuto v in vk) { Console.WriteLine(v); }

            //2 kék Gépkocsit klónozzon az ifából
            Gepkocsi[] tk = gyartosor.sorozatGyartas(prototype2, "Kék", 2);
            foreach (TeherAuto t in tk) { Console.WriteLine(t); }

            Console.ReadKey();

        }
    }

    //Minden gépkocsira általános
    public abstract class Gepkocsi : ICloneable
    {
        private string tipus; //propertyk
        public string Tipus
        {
            get { return tipus; }
            set { tipus = value; }
        }

        private int utasokSzama;
        public int UtasokSzama
        {
            get { return utasokSzama; }
            set { utasokSzama = value; }
        }

        private string szin;
        public string Szin
        {
            get { return szin; }
            set { szin = value; }
        }

        public Gepkocsi(string tipus, int utasokSzama)
        {
            this.tipus = tipus;
            this.utasokSzama=utasokSzama;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    //Versenyautó specifikus
    public class VersenyAuto : Gepkocsi
    {
        private int vegsebesseg;
        public int Vegsebesseg
        {
            get { return vegsebesseg; }
            set { vegsebesseg = value; }
        }

        public VersenyAuto(string tipus, int utasokSzama, int vegsebesseg) :base(tipus,utasokSzama)
        {
            this.vegsebesseg = vegsebesseg;
        }
    }

    //Teherauto specifikus
    public class TeherAuto : Gepkocsi
    {
        private int teherBiras;
        public int TeherBiras
        {
            get { return teherBiras; }
            set { teherBiras = value; }
        }

        public TeherAuto(string tipus, int utasokSzama, int teherBiras) : base(tipus, utasokSzama)
        {
            this.teherBiras = teherBiras;
        }
    }

    //A gyár klónozza a GÉPKOCSIKAT, lefesti őket pluszba.
    public class Gyar
    {
        public Gepkocsi[] sorozatGyartas(Gepkocsi g, string sz, int db)
        {
            Gepkocsi[] temp = new Gepkocsi[db];
            for (int i = 0; i < db; i++)
            {
                temp[i] = (Gepkocsi)g.Clone();
                temp[i].Szin = sz;
            }
            return temp;
        }
    }
}
