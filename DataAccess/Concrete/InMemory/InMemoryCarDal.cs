using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
        //    _cars = new List<Car>
        //{
        //    new Car{CarId=1, BrandId=1, ColorId=5, ModelYear="2013", DailyPrice=300, Description="Sorunsuz bir arabamız." },
        //    new Car{CarId=2, BrandId=1, ColorId=3, ModelYear="2011", DailyPrice=250, Description="Eski fakat temiz arabamız." },
        //    new Car{CarId=3, BrandId=2, ColorId=4, ModelYear="2016", DailyPrice=500, Description="Az kullanılmış arabamız." },
        //    new Car{CarId=4, BrandId=2, ColorId=7, ModelYear="2012", DailyPrice=700, Description="Yeni model arabamız." },
        //    new Car{CarId=5, BrandId=2, ColorId=9, ModelYear="2018", DailyPrice=1000, Description="En yeni arabamız." }

        //};
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId); //Linq

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        //public void Update(Car car)
        //{
        //    Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        //    carToUpdate.CarId = car.CarId;
        //    carToUpdate.BrandId = car.BrandId;
        //    carToUpdate.ColorId = car.ColorId;
        //    carToUpdate.DailyPrice = car.DailyPrice;
        //    carToUpdate.Description = car.Description;
        //    carToUpdate.ModelYear = car.ModelYear;
        //}

    }
}
