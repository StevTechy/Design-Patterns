using AbstractFactoryDatabaseExample.Entity_Framework;
using AbstractFactoryDatabaseExample.Entity_Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDatabaseExample.Repositories.Interfaces
{
    abstract class CustomerRepository : IRepository<Customer>
    {
        protected MyDbContext _db;

        public CustomerRepository()
        {
            _db = new MyDbContext();
        }

        public virtual IEnumerable<Customer> List
        {
            get { throw new NotImplementedException(); }
        }

        public virtual void Create(Customer entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public virtual Customer Find(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
