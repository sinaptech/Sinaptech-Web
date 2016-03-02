using Sinaptech.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Repositories
{
    public class TestCategoryRepository : ITestCategoryRepository<TestCategory>
    {
        private ApplicationDbContext db;
        public TestCategoryRepository()
        {
            db = new ApplicationDbContext();
        }
        public TestCategory Add(TestCategory entity)
        {
            var testcategory = db.TestCategories.Add(entity);
            Save();
            return testcategory;
        }

        public void Delete(TestCategory entity)
        {
            db.TestCategories.Remove(entity);
            Save();
        }

        public void Delete(int id)
        {
            var testcategory = db.TestCategories.Find(id);
            Delete(testcategory);
        }

        public TestCategory Get(int id)
        {
            return db.TestCategories.Find(id);
        }

        public IEnumerable<TestCategory> GetAll()
        {
            return db.TestCategories.ToList();
        }

        public TestCategory GetByName(string name)
        {
            return db.TestCategories.Where(p => p.CategoryName == name).FirstOrDefault();
        }

        public void Save()
        {
            db.SaveChangesAsync();
        }

        public void Update(TestCategory entity)
        {
            var testcategory = db.TestCategories.Find(entity.Id);
            testcategory.CategoryDescription = entity.CategoryDescription;
            testcategory.CategoryName = entity.CategoryName;
            Save();
        }
    }
}
