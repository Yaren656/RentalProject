using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomersManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomersManager(ICustomerDal colorDal)
        {
            _customerDal = colorDal;
        }
        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomersListed);
        }

        public IDataResult<Customer> GetById(int userId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.UserId == userId));
        }

        public IDataResult<Customer> GetByCompanyName(string companyName)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.CompanyName == companyName));
        }
    }
}
