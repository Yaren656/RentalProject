using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(Image image, CarImage carImage);
        IResult Delete(CarImage carImage);
        IResult Update(Image image, CarImage carImage);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int id);
        IDataResult<List<CarImage>> GetByCarId(int carId);
    }
}
