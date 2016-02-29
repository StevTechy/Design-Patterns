using AbstractFactoryDatabaseExample.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDatabaseExample.Repositories.Interfaces;
using AbstractFactoryDatabaseExample.Repositories;

namespace AbstractFactoryDatabaseExample.Factories
{
    class SQLRepositoryFactory : IRepositoryFactory
    {
        public CustomerRepository CreateCustomerRepository()
        {
            return new SQLCustomerRepository();
        }

        public SupplierRepository CreateSupplierRepository()
        {
            return new SQLSupplierRepository();
        }
    }
}
