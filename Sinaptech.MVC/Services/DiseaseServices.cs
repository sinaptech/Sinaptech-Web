using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sinaptech.Db.Models;
using Sinaptech.Logic;
using Sinaptech.MVC.ViewModels;

namespace Sinaptech.MVC.Services
{
    public class DiseaseServices
    {
        private DiseaseLogic _diseaseLogic;

        public DiseaseServices()
        {
            _diseaseLogic = new DiseaseLogic();
        }

        public ResultViewModel AddDisease(AddDiseaseViewModel  model,string creatorId)
        {
            var disease = new Disease()
            {
                NameGen = model.NameGeneral,
                NameSci = model.NameScientific,
                CreatorId =creatorId,
                Description = model.Description
            };
            disease = _diseaseLogic.AddDisease(disease);
            var result = new ResultViewModel() { EntityId = disease.DiseaseId, Message = "بیماری " + disease.NameGen + " با موفقیت اضافه شد", Status = true };
            return result;

        }
    

    #region Helpers

        #endregion
    }
}