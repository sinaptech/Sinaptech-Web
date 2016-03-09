using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Sinaptech.Api.ViewModels;

namespace Sinaptech.Api.Controllers
{
    [RoutePrefix("api/LabTests")]
    public class LabTestsController : ApiController
    {
        InsertLabTest[] labTests = new InsertLabTest[]
        {
            new InsertLabTest { NameGen = "آزمایش خون", CurrentPrice = 10000,TestDescription = "توضیحات آزمایش خون"},
            new InsertLabTest {NameGen = "آزمایش غربالگری", CurrentPrice = 20000,CurrentPriceAfterDiscount = 18000}
        };


    }
}
