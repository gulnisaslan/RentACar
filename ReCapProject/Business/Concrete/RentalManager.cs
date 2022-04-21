﻿using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Core.Aspects.Transaction;
using Core.Aspects.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DtOs;
using System;
using System.Collections.Generic;
using System.Linq;
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
        [SecuredOperation("brand.add,admin")]
        [ValidationAspect(typeof(RentalValidator))]
        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Add(Rental rental)
        {
            IResult result = BusinessRules.Run(IsRentable(rental));
            if (result != null)
                return result;
           

            _rentalDal.Add(rental);
            return new SuccessResult(RentalMessages.RentalAdded);
        }



        [SecuredOperation("brand.delete,admin")]
        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(RentalMessages.RentalAdded);
        }
        [SecuredOperation("brand.list,admin")]
        [CahceAspect(duration: 10)]
        [PerformanceAspect(5)]
        public IDataResult<List<Rental>> GetAll()
        {

            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), RentalMessages.RentalListed);

        }
        [SecuredOperation("brand.list,admin")]
        [CahceAspect(duration: 10)]
        [PerformanceAspect(5)]
        public IDataResult<List<Rental>> GetById(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.Id == id), RentalMessages.RentalListed);
        }
        [SecuredOperation("brand.list,admin")]
        [CahceAspect(duration: 10)]
        [PerformanceAspect(5)]
        public IDataResult<List<RentDetailDTOs>> GetRentDetailDTO()
        {
            return new SuccessDataResult<List<RentDetailDTOs>>(_rentalDal.RentDetails());
        }

        [ValidationAspect(typeof(RentalValidator))]
        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(RentalMessages.RentalUpdated);
        }


        public IResult CheckIfReturnDateByCarId(int carId)
        {
            var result = _rentalDal.GetAll(ci => ci.CarId == carId && ci.ReturnDate==null);
            if (result.Count > 0)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }
        


        public IResult IsRentable(Rental rental)
        {
            var result = _rentalDal.GetAll(r => r.CarId == rental.CarId);
            if (result.Any(r => r.RentDate == rental.RentDate && r.RentDate == rental.ReturnDate))
                return new ErrorResult(RentalMessages.RentalDidNotAdd);

            return new SuccessResult();

        }


    }
}
