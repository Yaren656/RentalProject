using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, MyDatabaseContext>, ICarDal  //Car'la ilgili veri tabanı işleri
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join s in context.Colors
                             on c.ColorName equals s.ColorName
                             join i in context.CarImages
                             on c.CarId equals i.CarId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 CarName = c.CarName,
                                 ColorName=s.ColorName,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
