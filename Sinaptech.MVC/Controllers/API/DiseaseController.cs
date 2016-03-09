using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Sinaptech.MVC.Services;
using Sinaptech.MVC.ViewModels;

namespace Sinaptech.MVC.Controllers.API
{
    public class DiseaseController : ApiController
    {
        private DiseaseServices _diseaseServices;

        public DiseaseController()
        {
            _diseaseServices=new DiseaseServices();
        }

        // GET: api/Disease
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Disease/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Disease
        public void Post(AddDiseaseViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return;
            }
           ResultViewModel result= _diseaseServices.AddDisease(model, User.Identity.GetUserId());
          
                Ok();
           
        }

        // PUT: api/Disease/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Disease/5
        public void Delete(int id)
        {
        }
    }
}
