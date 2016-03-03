using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Models
{
    public class TestCategory
    {
        public int TestCategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        //ye TestCategory mitune n ta LabTest dashte bashe va ye LabTest mitune motoalegh be n ta TestCategory bashe
        // ??? N -> N ?
        public virtual ICollection<LabTest> LabTests { get; set; }
    }
}
