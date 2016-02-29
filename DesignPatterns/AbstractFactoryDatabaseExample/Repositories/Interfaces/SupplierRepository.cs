using AbstractFactoryDatabaseExample.Entity_Framework;
using AbstractFactoryDatabaseExample.Entity_Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDatabaseExample.Repositories.Interfaces
{
    abstract class SupplierRepository : IRepository<Supplier>
    {
        protected MyDbContext _db;

        public SupplierRepository()
        {
            _db = new MyDbContext();
        }

        public virtual IEnumerable<Supplier> List
        {
            get { throw new NotImplementedException(); }
        }

        public virtual void Create(Supplier entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(Supplier entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(Supplier entity)
        {
            throw new NotImplementedException();
        }

        public virtual Supplier Find(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
