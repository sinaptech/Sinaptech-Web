using Sinaptech.Db.Models;
using Sinaptech.Db.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaptech.Logic
{
  public  class LabTestLogic
    {
        private ILabTestRepository<LabTest> _labTests;
        public LabTestLogic()
        {
            _labTests = new LabTestRepository();
        }

        public LabTest AddLabTest(LabTest labTest)
        {
            return _labTests.Add(labTest);
        }


    }
}
