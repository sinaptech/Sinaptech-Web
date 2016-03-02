using Sinaptech.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Repositories
{
    public class LabTestRepository : ILabTestRepository<LabTest>
    {
        private ApplicationDbContext db;
        public LabTestRepository()
        {
            db = new ApplicationDbContext();
        }
        public LabTest Add(LabTest entity)
        {
           var labTest= db.LabTests.Add(entity);
            Save();
            return labTest;
        }

        public void Delete(LabTest entity)
        {
            db.LabTests.Remove(entity);
            Save();
        }

        public void Delete(int id)
        {
            var labTest = db.LabTests.Find(id);
            Delete(labTest);
        }

        public LabTest Get(int id)
        {
            return db.LabTests.Find(id);
        }

        public IEnumerable<LabTest> GetAll()
        {
            return db.LabTests.ToList();
        }

        public LabTest GetByNameSci(string name)
        {
            return db.LabTests.Where(p => p.NameSci == name).FirstOrDefault();
        }
        public LabTest GetByNameGen(string name)
        {
            return db.LabTests.Where(p => p.NameGen == name).FirstOrDefault();
        }

        public void Save()
        {
            db.SaveChangesAsync();
        }

        public void Update(LabTest entity)
        {
            var labTest = db.LabTests.Find(entity.Id);
            labTest.NameGen = entity.NameGen;
            labTest.NameSci = entity.NameSci;
            labTest.TestDescription = entity.TestDescription;
            labTest.TestCategories = entity.TestCategories;
            labTest.LabTestPrice = entity.LabTestPrice;
            Save();
        }
    }
}
