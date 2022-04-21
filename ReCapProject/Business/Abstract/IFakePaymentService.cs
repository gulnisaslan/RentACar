using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public  interface IFakePaymentService
    {
        IDataResult<List<FakeCard>> GetAll();
        IDataResult<FakeCard> GetById(int id);
        IResult Add(FakeCard fakeCard);
        IResult Delete(FakeCard fakeCard);
        IResult Update(FakeCard fakeCard );
    }
}
