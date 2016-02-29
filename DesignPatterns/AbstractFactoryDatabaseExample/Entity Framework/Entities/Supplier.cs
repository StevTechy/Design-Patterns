using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDatabaseExample.Entity_Framework.Entities
{
    class Supplier
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string BusinessUnit { get; set; }

        public string Group { get; set; }
    }
}
