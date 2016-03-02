﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Db.Models
{
   public class LabTestPrice
    {
        public int LabTestPriceId { get; set; }
        public int Price { get; set; }
        public int PriceAfterDiscount { get; set; }

        public DateTime FromDateTime { get; set; }

        //in bayad betune null ham baseh yani aslan gheymat nadashte bashe
        //ye LabTestPrice bayad hatman LabTest dashte bashe va yedune ham bashe vali ye LabTest mitune yeki ya hichi LabTestPrice dashte bashe
        [ForeignKey("LabTest")]
        public int LabTestId { get; set; }

        public virtual LabTest LabTest { get; set; }



    }
}
