using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory_Pattern.Products.Interfaces;

namespace Abstract_Factory_Pattern.Factories.Interfaces
{
    interface AbstractPlatformFactory
    {
        AbstractProductOne MakeProductOne();

        AbstractProductTwo MakeProductTwo();
    }
}
