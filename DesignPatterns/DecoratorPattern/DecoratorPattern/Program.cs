using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sima kávé
            Espresso espresso = new Espresso();
            Console.WriteLine("Díszítő nélküli: Név:{0}, Ár: {1}", espresso.Name, espresso.Price);

            //Tejbe csomagolt kávé
            CoffeeTejDecorator tejjel = new CoffeeTejDecorator(espresso);
            Console.WriteLine("Tej Díszítővel: Név:{0}, Ár: {1}", tejjel.Name, tejjel.Price);

            //Tejbe és tejszínhabba csomagolt kávé
            CoffeeTejszinhabDecorator tejszinhabbal = new CoffeeTejszinhabDecorator(tejjel);
            Console.WriteLine("Tejszínhab és tej Díszítővel: Név:{0}, Ár: {1}", tejszinhabbal.Name, tejszinhabbal.Price);

            //Egyből az összes
            CoffeeBase maxos = new CoffeeTejszinhabDecorator(new CoffeeTejDecorator(new Espresso()));
            Console.WriteLine(maxos.Name, maxos.Price);

            Console.ReadKey();
        }
    }

    public abstract class CoffeeBase
    {
        public abstract string Name { get; }
        public abstract int Price { get; }
    }

    public class Espresso : CoffeeBase
    {
        public override string Name { get { return "Espresso"; } }

        public override int Price { get { return 150; } }
    }

    public abstract class CoffeeDecoratorBase : CoffeeBase
    {
        //Ezt fogjuk becsomagolni, HAS-A kapcsolat
        private CoffeeBase coffee;
        //A kávéra tesszük a pluszt
        public CoffeeDecoratorBase(CoffeeBase coffee)
        {
            this.coffee = coffee;
        }
        public override string Name { get { return coffee.Name; } }
        public override int Price { get { return coffee.Price; } }
    }

    public class CoffeeTejDecorator : CoffeeDecoratorBase
    {
        public CoffeeTejDecorator(CoffeeBase coffee) : base(coffee)
        {
        }

        public override string Name { get { return base.Name + " + tej"; } }
        public override int Price { get { return base.Price + 50; } }
    }

    public class CoffeeTejszinhabDecorator : CoffeeDecoratorBase
    {
        public CoffeeTejszinhabDecorator(CoffeeBase coffee) : base(coffee)
        {
        }

        public override string Name { get { return base.Name + " + tejszínhab"; } }
        public override int Price { get { return base.Price + 100; } }
    }
}
