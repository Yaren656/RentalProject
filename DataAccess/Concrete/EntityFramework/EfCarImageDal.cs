using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, MyDatabaseContext>, ICarImageDal
    {
        public List<CarImageDetailDto> GetCarImageDetails()
        {
            throw new NotImplementedException();
        }
    }
}
