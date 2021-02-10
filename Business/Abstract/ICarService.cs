using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetAll();
        Car GetByCarId(int id);
        List<CarDetailDto> GetCarDetails();
        List<CarDetailDto> GetAllByColorId(int id);
        List<CarDetailDto> GetAllByBrandId(int id);
        List<Car> GetByDailyPrice(decimal min, decimal max);
    }
}
