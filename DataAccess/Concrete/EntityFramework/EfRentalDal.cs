﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, MyDatabaseContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.CarId
                             join br in context.Brands
                             on c.BrandId equals br.BrandId
                             join u in context.Users
                             on r.CustomerId equals u.Id
                             join co in context.Customers
                             on r.CustomerId equals co.UserId

                             select new RentalDetailDto
                             {
                                  
                                  BrandName=br.BrandName,
                                  Id=r.Id,
                                  UserName=u.FirstName+" "+u.LastName,
                                  
                                  RentDate=r.RentDate,
                                  ReturnDate=(DateTime)r.ReturnDate

                             };
                return result.ToList();
            }

        }
    }
}
