using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IOperationService
    {
        IDataResult<List<Operation>> GetAll();
        IResult Add(Operation operation);

        IDataResult<List<Operation>> GetByPrice(int price);



    }
}
