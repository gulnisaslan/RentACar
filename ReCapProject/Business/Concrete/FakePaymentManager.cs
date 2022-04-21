using Business.Abstract;
using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class FakePaymentManager:IFakePaymentService
    {
        IFakePaymentDal _fakePaymentDal;

        public FakePaymentManager(IFakePaymentDal fakePaymentDal)
        {
            _fakePaymentDal = fakePaymentDal;
        }

        public IResult Add(FakeCard fakeCard)
        {
            _fakePaymentDal.Add(fakeCard);
            return new SuccessResult();
        }

        public IResult Delete(FakeCard fakeCard)
        {
            _fakePaymentDal.Delete(fakeCard);
                return new SuccessResult();
        }

        public IDataResult<List<FakeCard>> GetAll()
        {
            return new SuccessDataResult<List<FakeCard>>(_fakePaymentDal.GetAll());
        }

        public IDataResult<FakeCard> GetById(int id)
        {
            return new SuccessDataResult<FakeCard>(_fakePaymentDal.Get(f => f.Id == id));
        }

        public IResult Update(FakeCard fakeCard)
        {
            _fakePaymentDal.Update(fakeCard);
            return new SuccessResult();
        }
    }
}
