using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory_Pattern.Factories.Interfaces;
using Abstract_Factory_Pattern.Products;
using Abstract_Factory_Pattern.Products.Interfaces;

namespace Abstract_Factory_Pattern.Factories
{
    class PlatformOneFactory : AbstractPlatformFactory
    {
        public PlatformOneFactory()
        {
            Console.WriteLine("Platform One Factory has been initialized");
        }

        public AbstractProductOne MakeProductOne()
        {
            return new ProductOnePlatformOne();
        }

        public AbstractProductTwo MakeProductTwo()
        {
            return new ProductTwoPlatformOne();
        }
    }
}
