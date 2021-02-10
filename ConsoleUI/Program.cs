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



            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} -- {1}" , car.BrandName , car.ColorName);
            }
        }
    }
}
