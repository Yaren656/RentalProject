using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal colorDal)
        {
            _customerDal = colorDal;
        }
        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer GetById(int userId)
        {
            return _customerDal.Get(c => c.UserId == userId);
        }
    }
}
