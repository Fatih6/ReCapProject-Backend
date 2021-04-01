﻿using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<User> GetByMail(string email);
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int userId);

        IResult UpdateInfos(User user);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);



    }
}
