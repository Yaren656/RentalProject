using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
        {
            new Car{Id=1, BrandId=1, ColorId=5, ModelYear="2013", DailyPrice=300, Description="Sorunsuz bir arabamız." },
            new Car{Id=2, BrandId=1, ColorId=3, ModelYear="2011", DailyPrice=250, Description="Eski fakat temiz arabamız." },
            new Car{Id=3, BrandId=2, ColorId=4, ModelYear="2016", DailyPrice=500, Description="Az kullanılmış arabamız." },
            new Car{Id=4, BrandId=2, ColorId=7, ModelYear="2012", DailyPrice=700, Description="Yeni model arabamız." },
            new Car{Id=5, BrandId=2, ColorId=9, ModelYear="2018", DailyPrice=1000, Description="En yeni arabamız." }

        };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id); //Linq

            _cars.Remove(carToDelete);
        }
 

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByCategory(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList(); //Linq
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

    }
}
