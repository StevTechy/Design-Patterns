using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory_Pattern.Products.Interfaces;

namespace Abstract_Factory_Pattern.Products
{
    class ProductOnePlatformOne : AbstractProductOne
    {
        public ProductOnePlatformOne()
        {
            Console.WriteLine("I am a new Product (Product One Platform One)");
        }

        public void ProductOneSpecificMethod()
        {
            throw new NotImplementedException();
        }
    }
}
