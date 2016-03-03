using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sinaptech.Db.Models;

namespace Sinaptech.Db.Repositories
{
    public class TestPackagePriceRepository : ITestPackagePriceRepository<TestPackagePrice>
    {
        private ApplicationDbContext db;
        public TestPackagePriceRepository()
        {
            db=new ApplicationDbContext();
        }

        public TestPackagePrice Add(TestPackagePrice entity)
        {

            var testPackagPrice = db.TestPackagePrices.Add(entity);
            Save();
            return testPackagPrice;
        }

        public void Delete(TestPackagePrice entity)
        {
            db.TestPackagePrices.Remove(entity);
            Save();
        }

        public void Delete(int id)
        {
          
            var testPackagePrice = db.TestPackagePrices.Find(id);
            Delete(testPackagePrice);
        }

        public TestPackagePrice Get(int id)
        {
            return db.TestPackagePrices.FirstOrDefault(s => s.TestPackageId == id);
        }

        public TestPackagePrice GetByPriceAfterDiscount(int priceAftrDiscount)
        {
            return db.TestPackagePrices.FirstOrDefault(s => s.PriceAfterDiscount == priceAftrDiscount);
        }

        public IEnumerable<TestPackagePrice> GetAll()
        {
            return db.TestPackagePrices.ToList();
        }

        public TestPackagePrice GetByPrice(int price)
        {
            return db.TestPackagePrices.FirstOrDefault(s => s.Price == price);
        }

        public void Save()
        {
            db.SaveChangesAsync();
        }

        public void Update(TestPackagePrice entity)
        {
            var testPackagePrice = db.TestPackagePrices.Find(entity.TestPackagePriceId);
            testPackagePrice.Price = entity.Price;
            testPackagePrice.FromDateTime = entity.FromDateTime;
            testPackagePrice.PriceAfterDiscount = entity.PriceAfterDiscount;
            testPackagePrice.TestPackage = entity.TestPackage;
            testPackagePrice.TestPackageId = entity.TestPackageId;
           
            Save();
        }
    }
}
