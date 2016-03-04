using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sinaptech.Db.Models;

namespace Sinaptech.Db.Repositories
{
    public class TestPackageRepository : ITestPackageRepository<TestPackage>
    {
        ApplicationDbContext db;
        public TestPackageRepository()
        {
            db=new ApplicationDbContext();

        }
        public TestPackage Add(TestPackage entity)
        {
            var testPackage = db.TestPackages.Add(entity);
            Save();
            return testPackage;
        }

        public void Delete(TestPackage entity)
        {
            db.TestPackages.Remove(entity);
            Save();
        }

        public void Delete(int id)
        {
            var testPackage = db.TestPackages.FirstOrDefault(s => s.TestPackageId == id);
            Delete(testPackage);
        }

        public TestPackage Get(int id)
        {
            return db.TestPackages.FirstOrDefault(s => s.TestPackageId == id);
        }

        public IEnumerable<TestPackage> GetAll()
        {
            return db.TestPackages.ToList();
        }

        public TestPackage GetByNameSci(string name)
        {
           return db.TestPackages.FirstOrDefault(s => s.NameSci == name);
        }
        public TestPackage GetByNameGen(string name)
        {
            return db.TestPackages.FirstOrDefault(s => s.NameGen == name);
        }

        public void Save()
        {
            db.SaveChangesAsync();
        }

        public void Update(TestPackage entity)
        {
            var testPackage = db.TestPackages.Find(entity.TestPackageId);
            testPackage.NameGen = entity.NameGen;
            testPackage.NameSci = entity.NameSci;
            testPackage.Description = entity.Description;
            testPackage.TestPackagePrices = entity.TestPackagePrices;
            testPackage.LabTests = entity.LabTests;
            Save();
        }
    }
}
