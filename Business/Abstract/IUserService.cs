using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<UserDetailDto>> GetUserDetails();
        IDataResult<User> GetByUserId(int userId);
        IDataResult<List<User>> GetByCompanyName(string companyName);
        IResult Add(User user);


        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<User> GetByMail(string email);
    }
}
