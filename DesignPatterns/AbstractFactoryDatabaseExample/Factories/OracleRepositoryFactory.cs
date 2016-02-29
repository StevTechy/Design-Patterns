using AbstractFactoryDatabaseExample.Entity_Framework.Entities;
using AbstractFactoryDatabaseExample.Factories.Interfaces;
using AbstractFactoryDatabaseExample.Repositories;
using AbstractFactoryDatabaseExample.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDatabaseExample.Factories
{
    class OracleRepositoryFactory : IRepositoryFactory
    {
        public CustomerRepository CreateCustomerRepository()
        {
            return new OracleCustomerRepository();
        }

        public SupplierRepository CreateSupplierRepository()
        {
            return new OracleSupplierRepository();
        }
    }
}
