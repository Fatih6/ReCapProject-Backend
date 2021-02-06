//using DataAccess.Abstract;
//using Entities.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace DataAccess.Concrete.InMemory
//{
//    public class InMemoryColorDal : IColorDal
//    {
//        List<CarColor> _carColors;

//        public InMemoryColorDal()
//        {
//            _carColors = new List<CarColor>
//            {
//                new CarColor{ ColorId = 1, ColorName = "Red" },
//                new CarColor{ ColorId = 2, ColorName = "White" },
//                new CarColor{ ColorId = 3, ColorName = "Black" },
//                new CarColor{ ColorId = 4, ColorName = "Yellow" },
//                new CarColor{ ColorId = 5, ColorName = "Orange" },
//            };
//        }
//        public void Add(CarColor carColor)
//        {
//            _carColors.Add(carColor);
//        }

//        public void Delete(CarColor carColor)
//        {
//            var colorToDelete = _carColors.SingleOrDefault(cc=>cc.ColorId == carColor.ColorId);
//            _carColors.Remove(colorToDelete);
//        }

//        public List<CarColor> GetAll()
//        {
//            return _carColors;
//        }

//        public CarColor GetById(int colorId)
//        {
//            return _carColors.SingleOrDefault(cc=>cc.ColorId == colorId);
//        }

//        public void Update(CarColor carColor)
//        {
//            var colorToUpdate = _carColors.SingleOrDefault(cc=>cc.ColorId == carColor.ColorId);
//            colorToUpdate.ColorName = carColor.ColorName;
//        }
//    }
//}
