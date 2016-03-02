using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Repositories
{
   public interface IDiseaseRepository<T>
        {
        T Add(T entity);
        T Get(int id);
        T GetByNameSci(string name);
        T GetByNameGen(string name);
        IEnumerable<T> GetAll();
        void Update(T entity);
        void Delete(int id);
        void Delete(T entity);
        void Save();
    }
}
