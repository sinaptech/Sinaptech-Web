using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sinaptech.MVC.ViewModels
{
    public class DiseaseViewModel
    {
        public int DiseaseId { get; set; }
        public string NameGeneral { get; set; }
        public string NameScientific { get; set; }
        public string Description { get; set; }
    }
    public class AddDiseaseViewModel
    {
        [Required]
        [Display(Name = "نام عمومی بیماری")]
        [StringLength(maximumLength:100, ErrorMessage = "نام عمومی بیماری حداکثر 100 کاراکتر است")]
        public string NameGeneral { get; set; }

        [Display(Name = "نام علمی بیماری")]
        [StringLength(maximumLength: 100, ErrorMessage = "نام علمی بیماری حداکثر 100 کاراکتر است")]
        public string NameScientific { get; set; }

        [Display(Name = "توضیحات (کدهای اچ تی ام ال مجاز است)")]
        [DataType(DataType.Html)]
        public string Description { get; set; }

     
    }
}