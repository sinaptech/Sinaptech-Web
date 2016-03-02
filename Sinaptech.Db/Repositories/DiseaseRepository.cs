using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sinaptech.Db.Models;

namespace Sinaptech.Db.Repositories
{
    public class DiseaseRepository : IDiseaseRepository<Disease>
    {
        private ApplicationDbContext db;
        public DiseaseRepository()
        {
            db = new ApplicationDbContext();
        }
        public Disease Add(Disease entity)
        {
            var disease = db.Diseases.Add(entity);
            Save();
            return disease;
        }

        public void Delete(Disease entity)
        {
            db.Diseases.Remove(entity);
            Save();
        }

        public void Delete(int id)
        {
            var disease = db.Diseases.Find(id);
            Delete(disease);
        }

        public Disease Get(int id)
        {
            return db.Diseases.Find(id);
        }

        public IEnumerable<Disease> GetAll()
        {
            return db.Diseases.ToList();
        }

        public Disease GetByNameGen(string name)
        {
            return db.Diseases.FirstOrDefault(p => p.NameGen == name);
        }

        public Disease GetByNameSci(string name)
        {
            return db.Diseases.FirstOrDefault(p => p.NameSci == name);
        }

        public void Save()
        {
            db.SaveChangesAsync();
        }

        public void Update(Disease entity)
        {
            var disease = db.Diseases.Find(entity.DiseaseId);
            disease.NameGen = entity.NameGen;
            disease.NameSci = entity.NameSci;
            disease.Description = entity.Description;
            disease.LabTests = entity.LabTests;
            Save();
        }
    }
}
