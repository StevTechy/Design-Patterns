using AbstractFactoryDatabaseExample.Entity_Framework.Entities;
using AbstractFactoryDatabaseExample.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDatabaseExample.Repositories
{
    class SQLCustomerRepository : CustomerRepository
    {
        public override Customer Find(int Id)
        {
            return _db.Customers.Find(Id);
        }
    }
}
