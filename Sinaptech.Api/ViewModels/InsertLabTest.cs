using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sinaptech.Api.ViewModels
{
    public class InsertLabTest
    {
        public string NameSci { get; set; }
        public string NameGen { get; set; }
        public string TestDescription { get; set; }
        public int? CurrentPrice { get; set; }
        public int? CurrentPriceAfterDiscount { get; set; }
    }
}