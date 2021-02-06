//using DataAccess.Abstract;
//using Entities.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace DataAccess.Concrete.InMemory
//{
//    public class InMemoryCarDal : ICarDal
//    {
//        List<Car> _cars;
//        public InMemoryCarDal()
//        {
//            _cars = new List<Car>
//            {
//                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=2017,DailyPrice=300,Description="Mercedes C180"},
//                new Car{CarId=2,BrandId=3,ColorId=2,ModelYear=2016,DailyPrice=250,Description="BMW i8"},
//                new Car{CarId=3,BrandId=4,ColorId=2,ModelYear=2007,DailyPrice=200,Description="Rang Rover"},
//                new Car{CarId=4,BrandId=2,ColorId=3,ModelYear=2019,DailyPrice=350,Description="Tesla Model x"}
//            };
//        }

//        public void Add(Car car)
//        {
//            _cars.Add(car);
//        }

//        public void Delete(Car car)
//        {
//            var carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
//            _cars.Remove(carToDelete);
//        }

//        public List<Car> GetAll()
//        {
//            return _cars;
//        }

//        public Car GetById(int carId)
//        {
//            return _cars.SingleOrDefault(c=>c.CarId == carId);
//        }

//        public void Update(Car car)
//        {
//            var carToUpdate = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
//            carToUpdate.BrandId = car.BrandId;
//            carToUpdate.ColorId = car.ColorId;
//            carToUpdate.ModelYear = car.ModelYear;
//            carToUpdate.DailyPrice = car.DailyPrice;
//            carToUpdate.Description = car.Description;

//        }
//    }
//}
