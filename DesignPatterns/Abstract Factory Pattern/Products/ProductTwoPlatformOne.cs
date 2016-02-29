using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory_Pattern.Products.Interfaces;

namespace Abstract_Factory_Pattern.Products
{
    class ProductTwoPlatformOne : AbstractProductTwo
    {
        public ProductTwoPlatformOne()
        {
            Console.WriteLine("I am a new Product (Product Two Platform One)");
        }

        public void ProductTwoSpecificMethod()
        {
            throw new NotImplementedException();
        }
    }
}
