using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory_Pattern.Factories;

namespace Abstract_Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing factories...");

            PlatformOneFactory platformOneFactory = new PlatformOneFactory();
            PlatformTwoFactory platformTwoFactory = new PlatformTwoFactory();

            Console.WriteLine("Creating products");

            platformOneFactory.MakeProductOne();
            platformOneFactory.MakeProductTwo();

            platformTwoFactory.MakeProductOne();
            var product = platformTwoFactory.MakeProductTwo();

            Console.WriteLine("Factory closing...");

            Console.ReadKey();
        }
    }
}
