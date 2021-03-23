using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IResult IsRentable(Rental rental);
        IDataResult<List<Rental>> GetAllByCarId(int carId);
        IResult IsDelivered(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
    }
}
