using Business.Concrete;
using DataAccess.Abstract;
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

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("Günlük ücreti: " + car.DailyPrice);
                Console.WriteLine("Açıklaması: " + car.Description);
                Console.WriteLine("********");
            }

            Console.WriteLine("BrandId'si 8 olanlar: ");
            foreach (var car in carManager.GetByBrandId(8).Data)
            {
                Console.WriteLine(car.Description + " " + car.BrandName);
            }
            Console.WriteLine("--------------");
            Console.WriteLine("ColorId'si 12 olanlar: ");
            foreach (var car in carManager.GetByColorId(12).Data)
            {
                Console.WriteLine(car.Description + " " + car.BrandName);
            }

            Console.WriteLine("--------------");
            Console.WriteLine(carManager.Add(new Car { Description = "i", DailyPrice = 0 }).Message);
            Console.WriteLine("--------------");

            Console.WriteLine("Markalarımız : ");
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine("--------------");

            Console.WriteLine("Renklerimiz : ");
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }

            Console.WriteLine("--------------");
            CarManager carManager2 = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("\nSistemdeki Adı: " + car.CarName + 
                    "\nMarkası: " + car.BrandName + "\nRengi: " + car.ColorName + "\nGünlük Fiyatı: " + car.DailyPrice);
            }
            Console.WriteLine("--------------");

            UserManager user = new UserManager(new EfUserDal());
            Console.WriteLine(user.Add(new User { FirstName = "o", LastName = "y" }).Message);


            Console.WriteLine("--------------");
            
            RentalManager rental = new RentalManager(new EfRentalDal());
            Console.WriteLine(  rental.Add(new Rental { Id = 2, CarId = 2, CustomerId = 3 }).Message);


        }
    }
}
