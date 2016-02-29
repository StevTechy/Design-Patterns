﻿using AbstractFactoryDatabaseExample.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDatabaseExample.Factories.Interfaces
{
    interface IRepositoryFactory
    {
        CustomerRepository CreateCustomerRepository();

        SupplierRepository CreateSupplierRepository();
    }
}