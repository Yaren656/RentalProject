using Core.DataAccess.EntityFramework;
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
        //public List<UserDetailDto> GetUserDetails()
        //{
        //    using (MyDatabaseContext context = new MyDatabaseContext())
        //    {
        //        var result = from r in context.Rentals
        //                     join u in context.Users
        //                     on r.Id equals u.UserId
        //                     select new RentalDetailDto
        //                     {
        //                         Id = u.UserId

        //                     };
        //        //return result.ToList();
        //    }

        //}
    }
}
