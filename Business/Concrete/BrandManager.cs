using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;  //Constructor injection

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public List<Brand> GetAll()
        {
            //İş kodları
            return _brandDal.GetAll();
        }

        //Select * from Brands where BrandId = __
        public Brand GetById(int brandId)
        {
            return _brandDal.Get(b=>b.BrandId == brandId);
        }
    }
}
