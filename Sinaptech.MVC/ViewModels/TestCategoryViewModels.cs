using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.MVC.ViewModels
{
    public class AddTestCategoryViewModel
    {
        [Required]
        [Display(Name="نام دسته بندی")]
        public string Name { get; set; }

        [Display(Name="توضیحات")]
        [Required]
        [DataType(DataType.Html)]
        public string Description { get; set; }
    }
}
