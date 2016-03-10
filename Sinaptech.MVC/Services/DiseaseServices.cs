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

        public ResultViewModel AddDisease(AddDiseaseViewModel model, string creatorId)
        {
            var disease = new Disease()
            {
                NameGen = model.NameGeneral,
                NameSci = model.NameScientific,
                CreatorId = creatorId,
                Description = model.Description
            };
            disease = _diseaseLogic.AddDisease(disease);
            var result = new ResultViewModel() { EntityId = disease.DiseaseId, Message = "بیماری " + disease.NameGen + " با موفقیت اضافه شد", Status = true };
            return result;

        }

        public DiseaseViewModel GetById(int id)
        {
            var disease = _diseaseLogic.GetById(id);
            return DiseaseToViewModel(disease);
        }

        public List<DiseaseViewModel> GetAllDiseases()
        {
            var diseases = _diseaseLogic.GetAll();
            return DiseaseListToViewModel(diseases);
        }


        #region Helpers
        private DiseaseViewModel DiseaseToViewModel(Disease disease)
        {
            return new DiseaseViewModel()
            {
                Description = disease.Description,
                DiseaseId = disease.DiseaseId,
                NameGeneral = disease.NameGen,
                NameScientific = disease.NameSci
            };
        }
        private List<DiseaseViewModel> DiseaseListToViewModel(List<Disease> diseases)
        {
            var model = new List<DiseaseViewModel>();
            foreach (var item in diseases)
            {
                model.Add(DiseaseToViewModel(item));
            }
            return model;
        }
        #endregion
    }
}