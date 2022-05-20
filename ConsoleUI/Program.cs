using Bussiness.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewCar();
            //NewBrand();

            Car car1 = new Car { Name = "R", DailyPrice = 0, Description = "Açıklamamız", ModelYear = 2020 };

            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(car1);
            //carManager.GetAll();

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            
            //brandManager.Add(brand1);



        }

        private static void NewBrand()
        {
            Brand brand1 = new Brand { BrandName = "Renault" };
        }

        private static void NewCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car { Name = "R", DailyPrice = 0, Description = "Açıklamamız", ModelYear = 2020 };
            carManager.Add(car1);
        }
    }
}
