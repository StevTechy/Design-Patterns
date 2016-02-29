using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDatabaseExample.Repositories.Interfaces
{
    public interface IRepository<T>
    {
 
        IEnumerable<T> List { get; }
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Find(int Id);
         
    }
}
