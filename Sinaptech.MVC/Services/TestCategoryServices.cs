using Sinaptech.Db.Models;
using Sinaptech.Logic;
using Sinaptech.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.MVC.Services
{
    public class TestCategoryServices
    {
        private TestCategoryLogic _tc;
        public TestCategoryServices()
        {
            _tc = new TestCategoryLogic();
        }

        public ResultViewModel AddTestCategory(AddTestCategoryViewModel model)
        {
            var testcategory = new TestCategory();
            testcategory.CategoryDescription = model.Description;
            testcategory.CategoryName = model.Name;
            testcategory = _tc.AddTestCategory(testcategory);
            var result = new ResultViewModel() { EntityId = testcategory.TestCategoryId, Message = "دسته بندی " + testcategory.CategoryName + " با موفقیت اضافه شد", Status = true };
            return result;
        }

        #region Helpers

        #endregion

    }
}
