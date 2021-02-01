using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                //Console.WriteLine(car.Description + " - Günlük fiyatı : " + car.DailyPrice);
                Console.WriteLine("Model Year : "+ car.ModelYear + "\nDaily Price : " + car.DailyPrice
                    + "\nDescription : " + car.Description + "\n");
            }
        }
    }
}
