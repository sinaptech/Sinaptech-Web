using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sinaptech.Db.Models;
using Sinaptech.Db.Repositories;

namespace Sinaptech.Logic
{
   public class DiseaseLogic
   {
       private IDiseaseRepository<Disease> _diseaseRepository;

       public DiseaseLogic()
       {
           _diseaseRepository=new DiseaseRepository();
       }

       public Disease AddDisease(Disease disease)
       {
           return _diseaseRepository.Add(disease);
       }

        public List<Disease> GetAll()
        {
            return _diseaseRepository.GetAll().ToList();
        }

        public Disease GetById(int id)
        {
            return _diseaseRepository.Get(id);
        }
    }
}
