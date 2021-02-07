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
            Console.WriteLine("--------------");
            carManager.Add(new Car { CarId = 87, Description = "j", DailyPrice = 0 });
            Console.WriteLine("--------------");

            Console.WriteLine("Markalarımız : ");
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine("--------------");
            Console.WriteLine("Renklerimiz : ");
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine( color.ColorName);
            }

            Console.WriteLine("--------------");
            CarManager carManager2 = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("\nSistemdeki Adı: " + car.CarName + "\nMarkası: " + car.BrandName + "\nRengi: " + car.ColorName + "\nGünlük Fiyatı: " + car.DailyPrice);

            }


        }
    }
}
