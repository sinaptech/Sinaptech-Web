using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sinaptech.Db.Models;

namespace Sinaptech.Db.Repositories
{
    public class LabTestPriceRepository : ILabTestPriceRepository<LabTestPrice>
    {
        private ApplicationDbContext db;
        public LabTestPriceRepository()
        {
            db=new ApplicationDbContext();
        }

        public LabTestPrice Add(LabTestPrice entity)
        {

            var labTestPrice = db.LabTestPrices.Add(entity);
            Save();
            return labTestPrice;
        }

        public void Delete(LabTestPrice entity)
        {
            db.LabTestPrices.Remove(entity);
            Save();
        }

        public void Delete(int id)
        {
          
            var labTestPrice = db.LabTestPrices.Find(id);
            Delete(labTestPrice);
        }

        public LabTestPrice Get(int id)
        {
            return db.LabTestPrices.FirstOrDefault(s => s.LabTestPriceId == id);
        }

        public LabTestPrice GetByPriceAfterDiscount(int priceAftrDiscount)
        {
            return db.LabTestPrices.FirstOrDefault(s => s.PriceAfterDiscount == priceAftrDiscount);
        }

        public IEnumerable<LabTestPrice> GetAll()
        {
            return db.LabTestPrices.ToList();
        }

        public LabTestPrice GetByPrice(int price)
        {
            return db.LabTestPrices.FirstOrDefault(s => s.Price == price);
        }

        public void Save()
        {
            db.SaveChangesAsync();
        }

        public void Update(LabTestPrice entity)
        {
            var labTestPrice = db.LabTestPrices.Find(entity.LabTestPriceId);
            labTestPrice.Price = entity.Price;
            labTestPrice.FromDateTime = entity.FromDateTime;
            labTestPrice.PriceAfterDiscount = entity.PriceAfterDiscount;
            labTestPrice.LabTest = entity.LabTest;
            labTestPrice.LabTestId = entity.LabTestId;
            Save();
        }
    }
}
