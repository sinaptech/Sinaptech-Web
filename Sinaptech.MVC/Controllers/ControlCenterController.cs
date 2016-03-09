using Sinaptech.MVC.Services;
using Sinaptech.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sinaptech.MVC.Controllers
{
    public class ControlCenterController : Controller
    {
        private TestCategoryServices _testCategoryService;
        public ControlCenterController()
        {
            _testCategoryService = new TestCategoryServices();
        }
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult TestCategories()
        {
            
            return View(_testCategoryService.GetAllTestCategories());
        }

        [HttpGet]
        public ActionResult AddTestCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTestCategory(AddTestCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = _testCategoryService.AddTestCategory(model);
                return Json(new { status = result.Status, text = result.Message });
            }
            else
            {
                return Json(new { status = false, text = "اطلاعات ارسالی ناقص است." });
            }
        }
    }
}