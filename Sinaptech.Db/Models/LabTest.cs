using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Models
{
   public class LabTest
    {
        public int LabTestId { get; set; }
        public string NameSci { get; set; }
        public string NameGen { get; set; }
        public string TestDescription { get; set; }
        public int? CurrentPrice { get; set; }
        public int? CurrentPriceAfterDiscount { get; set; }

        //ye TestCategory mitune n ta LabTest dashte bashe va ye LabTest mitune motoalegh be n ta TestCategory bashe
        public virtual ICollection<TestCategory> TestCategories { get; set; }

        //ye Disease mitune hichi ya n ta LabTest dashte bashe va ye LabTest ham mitune be hichi ya n ta Disease mortabet bashe
        public virtual ICollection<Disease> Diseases { get; set; }

        //ye LabTestPrice bayad hatman LabTest dashte bashe va yedune ham bashe vali ye LabTest mitune yeki ya hichi LabTestPrice dashte bashe
        public virtual ICollection<LabTestPrice> LabTestPrices { get; set; }

        public virtual ICollection<OrderDetail> OrderDetailses { get; set; }

        //ye TestPackage mitune n ta LabTest dashte bashe va ye LabTest mitune ozve n ta TestPackage bashe
        public virtual ICollection<TestPackage> TestPackages { get; set; }
        public virtual string CreatorId { get; set; }

    }
}
