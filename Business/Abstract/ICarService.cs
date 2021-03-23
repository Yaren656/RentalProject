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
        IDataResult<CarDetailDto> GetById(int carId);
        IDataResult<List<Car>> GetByBrandId(int brandId);
        IDataResult<List<Car>>GetByColorId(int colorId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult TransactionalOperation(Car car);
        IDataResult<List<CarDetailDto>>GetAllByBrand(int brandId);
        IDataResult<List<CarDetailDto>> GetAllByColor(int colorId);
        IDataResult<List<CarDetailDto>> GetAllByColorIdAndBrandId(int colorId, int brandId);
        IDataResult<List<CarDetailDto>> GetCarDetailsByCarId(int carId);
    }
}
