using Business.Concrete;
using DataAccess.Concrete.EntityFramework.Repository;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            UserManager userManager = new UserManager(new EfUserDal());

            //Console.WriteLine("\n\nGünlük fiyat aralığı 200 ile 250 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            //foreach (var car in carManager.GetByDailyPrice(200, 250))
            //{
            //    Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            //}

            //Console.WriteLine("Brand Id'si 2 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            //foreach (var car in carManager.GetAllByBrandId(2))
            //{
            //    Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            //}
            //CarTest(carManager);

            //CustomerAdd(customerManager);

            //UserAdd(userManager);
        }

        private static void CustomerAdd(CustomerManager customerManager)
        {
            customerManager.Add(new Customer { UserId = 4, CompanyName = "Ankara bilişim" });
            customerManager.Add(new Customer { UserId = 5, CompanyName = "İstanbul bilişim" });
            customerManager.Add(new Customer { UserId = 6, CompanyName = "İzmir elektrik" });
        }

        private static void UserAdd(UserManager userManager)
        {
            userManager.Add(new User { FirstName = "Cemal", LastName = "artı", Email = "cemal@gmail.com", Password = "123321" });
            userManager.Add(new User { FirstName = "Mehmet", LastName = "çatı", Email = "mehmet123@gmail.com", Password = "321123" });
            userManager.Add(new User { FirstName = "Yusuf", LastName = "sert", Email = "celikler123321@gmail.com", Password = "12354" });
            userManager.Add(new User { FirstName = "Fatih", LastName = "ekmek", Email = "123f321@gmail.com", Password = "123456" });
            userManager.Add(new User { FirstName = "Mehmet", LastName = "askı", Email = "mhmask1@gmail.com", Password = "54321" });
            userManager.Add(new User { FirstName = "mert", LastName = "dalman", Email = "mert12333@gmail.com", Password = "3216543" });
        }

        private static void CarTest(CarManager carManager)
        {
            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("{0} -- {1} -- {2}", car.BrandName, car.ColorName, car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
