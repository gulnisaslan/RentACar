using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface IUserService
    {
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
         IDataResult<List<User>> GetById(int id);
        IDataResult<List<User>> GetAll();
        User GetByEmail(string email);
        List<OperationClaim> GetClaims(User user);

    }
}
