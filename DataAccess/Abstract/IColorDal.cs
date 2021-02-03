using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IColorDal
    {
        List<CarColor> GetAll();
        CarColor GetById(int colorId);
        void Add(CarColor carColor);
        void Delete(CarColor carColor);
        void Update(CarColor carColor);
    }
}
