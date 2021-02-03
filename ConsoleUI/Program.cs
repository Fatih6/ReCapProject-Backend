using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("-----------------LİSTED----------------");

            carManager.Add(new Car { CarId = 5, BrandId = 2, ColorId = 4, ModelYear = 2021, DailyPrice = 400, Description = "Tesla Z" });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("-----------------ADDİNG----------------");

            carManager.Delete(new Car { CarId = 3 });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("----------------DELETİNG---------------");

            carManager.Update(new Car { CarId = 4, DailyPrice = 450, Description = "Arabaya Zam Yapıldı." }) ;
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("----------------UPDATİNG---------------");
        }
    }
}
