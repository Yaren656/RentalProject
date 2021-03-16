using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }



        public IResult Add(IFormFile file, CarImage carImage)
        {
            IResult result = BusinessRules.Run(
                CheckIfCarImageLimitExceeded(carImage.CarId)
                );

            if (result != null)
            {
                return new ErrorResult(Messages.CarImageLimitExceeded);
            }

            var pathResult = FileHelper.Add(file);
            carImage.ImagePath = pathResult.Message;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImageAdded);
        }

        public IResult Delete(CarImage carImage)
        {
            var result = _carImageDal.Get(c => c.CarId == carImage.CarId);
            FileHelper.Delete(result.ImagePath);
           _carImageDal.Delete(carImage);
            

            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.CarId == id));
        }

        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == carId));
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            IResult result = BusinessRules.Run(
                CheckIfCarImageIdIsNotExists(carImage.CarId),
                CheckIfCarImageLimitExceeded(carImage.CarId)
                );

            if (result != null)
            {
                return result;
            }

            var res1 = _carImageDal.Get(c => c.CarId == carImage.CarId);
            var res2 = FileHelper.Update(file, res1.ImagePath);
            carImage.ImagePath = res2.Message;
            _carImageDal.Update(carImage);

            return new SuccessResult();
        }

        private IDataResult<CarImage> CreateFile(Image image, CarImage carImage)
        {
            string path = Directory.GetCurrentDirectory() + "\\wwwroot";
            string folder = "\\images\\";
            string defaultImage = (folder + "CarRental(default).jfif").Replace("\\", "/");

            if (image.Files == null)
            {
                carImage.ImagePath = defaultImage;
            }
            else
            {
                string extension = Path.GetExtension(image.Files.FileName);
                string guid = Guid.NewGuid().ToString() + DateTime.Now.Millisecond + "_" + DateTime.Now.Hour + extension + "_" + DateTime.Now.Minute;
                string imagePath = folder + guid + extension;

                using (FileStream fileStream = File.Create(path + imagePath))
                {
                    image.Files.CopyTo(fileStream);
                    fileStream.Flush();
                    carImage.ImagePath = (imagePath).Replace("\\", "/");
                }
            }

            carImage.Date = DateTime.Now;
            return new SuccessDataResult<CarImage>(carImage);
        }

        private IResult DeleteFile(CarImage carImage)
        {
            var result = _carImageDal.Get(c => c.CarId == carImage.CarId);
            string path = Directory.GetCurrentDirectory() + "\\wwwroot";
            string folder = "\\images\\";
            string defaultImage = (folder + "CarRental(default).jfif").Replace("\\", "/");

            try
            {
                if (result.ImagePath != defaultImage)
                {
                    File.Delete(path + result.ImagePath);
                }
            }
            catch (Exception)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        private IDataResult<CarImage> UpdateFile(Image image, CarImage carImage)
        {
            DeleteFile(carImage);
            var newImage = CreateFile(image, carImage).Data;

            return new SuccessDataResult<CarImage>(newImage);
        }

        private IResult CheckIfCarImageIdIsNotExists(int carImageId)
        {
            var result = _carImageDal.Get(c => c.CarId == carImageId);
            if (result == null)
            {
                return new ErrorResult(Messages.CarImageIsNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfCarImageLimitExceeded(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if (result >= 5)
            {
                return new ErrorResult(Messages.CarImageLimitExceeded);
            }
            return new SuccessResult();
        }

        
    }
}
