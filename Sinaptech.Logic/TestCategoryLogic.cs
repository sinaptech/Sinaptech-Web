using Sinaptech.Db.Models;
using Sinaptech.Db.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Logic
{
    public class TestCategoryLogic
    {
        private ITestCategoryRepository<TestCategory> _testCategories;
      
        public TestCategoryLogic()
        {
            _testCategories = new TestCategoryRepository();
        }

        public TestCategory AddTestCategory(TestCategory testcategory) {
            return _testCategories.Add(testcategory);
        }

        public IEnumerable<TestCategory> GetAllTestCategories()
        {
            return _testCategories.GetAll();
        } 
    }
}
