using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Validation;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OperationManager : IOperationService
    {
        IOperationDal _operationDal;

        public OperationManager(IOperationDal operationDal)
        {
            _operationDal = operationDal;
        }
        [ValidationAspect(typeof(OperationValidator))]
        public IResult Add(Operation operation)
        {
            _operationDal.Add(operation);
            return new SucessResult();
        }

        public IDataResult<List<Operation>> GetAll()
        {
            return new SuccessDataResult<List<Operation>>(_operationDal.GetAll());
        }

        public IDataResult<List<Operation>> GetByPrice(int price)
        {
            return new SuccessDataResult<List<Operation>>(_operationDal.GetAll(x=>x.Price>price));
        }
    }
}
