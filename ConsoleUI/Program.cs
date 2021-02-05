using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car { CarId = 87, Description = "j", DailyPrice = 0 }); 
            Console.WriteLine("--------------");

            foreach (var car in carManager.GetAll())
            {
                
                Console.WriteLine("Günlük ücreti: "+ car.DailyPrice);
                Console.WriteLine("Açıklaması: " + car.Description);
                Console.WriteLine("********");
            }

            Console.WriteLine("BrandId'si 8 olanlar: ");
            foreach (var car in carManager.GetCarsByBrandId(8))
            {
                Console.WriteLine(car.Description +" " + car.BrandName);
            }
            Console.WriteLine("--------------");
            Console.WriteLine("ColorId'si 12 olanlar: ");
            foreach (var car in carManager.GetCarsByColorId(12))
            {
                Console.WriteLine(car.Description + " " + car.BrandName);
            }
        }
    }
}
