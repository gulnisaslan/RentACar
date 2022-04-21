﻿using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Caching;
using Core.Aspects.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarBrandManager : ICarBrandService
       
    {
        ICarBrandDal _carBrandDal;

        public CarBrandManager(ICarBrandDal carBrandDal)
        {
            _carBrandDal = carBrandDal;
        }
        [SecuredOperation("carbrand,admin")]
        [ValidationAspect(typeof(CarBrandValidator))]
        [CahceAspect(10)]
        public IResult Add(CarBrand carBrand)
        { 
              _carBrandDal.Add(carBrand);
                return new SuccessResult(CarBrandMessages.CarBrandAdded);
           
        }

        [SecuredOperation("carbrand,admin")]
        [CahceAspect(10)]
        public IResult Delete(CarBrand carBrand)
        {
        _carBrandDal.Delete(carBrand);
         return new SuccessResult(CarBrandMessages.CarBrandDeleted);
         }

        public IDataResult<List<CarBrand>> GetAll()
        {
            return new SuccessDataResult<List<CarBrand>>(_carBrandDal.GetAll(),CarBrandMessages.CarBrandListed);
           
        }

        public IDataResult< List<CarBrand>> GetById(int id)
        {
            return new SuccessDataResult<List<CarBrand>> (_carBrandDal.GetAll(c => c.Id == id),CarBrandMessages.CarBrandListed)  ;
              
          }

        [SecuredOperation("carbrand,admin")]
        [ValidationAspect(typeof(CarBrandValidator))]
        public IResult Update(CarBrand carBrand)
        {
            _carBrandDal.Update(carBrand);
            return new SuccessResult(CarBrandMessages.CarBrandUpdated);
        }

        }

    
    }

