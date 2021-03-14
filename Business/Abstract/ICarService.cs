using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<Car> GetById(int carId);
        IDataResult<List<Car>> GetByBrandId(int brandId);
        IDataResult<List<Car>>GetByColorId(int colorId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult TransactionalOperation(Car car);
        IDataResult<List<Car>>GetAllByBrand(int brandId);
    }
}
