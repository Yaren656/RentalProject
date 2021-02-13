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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            if(rental.ReturnDate <DateTime.Today)
            {
                return new ErrorResult (Messages.RentalNotAccepted);
            }
            _rentalDal.Add(rental);

            return new SuccessResult(Messages.RentalAdded);
        }
    }
}
