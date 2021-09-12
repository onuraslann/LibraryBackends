using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class BookTypeManager : IBookTypeService
    {
        IBookTypeDal _bookTypeDal;

        public BookTypeManager(IBookTypeDal bookTypeDal)
        {
            _bookTypeDal = bookTypeDal;
        }

        public IResult Add(BookType bookType)
        {
            IResult result = BusinessRules.Run(CheckIfBookNameExist(bookType.Type));
            if (result != null)
            {
                return result;
            }
            _bookTypeDal.Add(bookType);
            return new SucessResult(Messages.BookTypeAdded);
        }

        public IResult Delete(BookType bookType)
        {
            _bookTypeDal.Add(bookType);
            return new SucessResult(Messages.BookTypeDeleted);
        }

        public IDataResult<List<BookType>> GetAll()
        {
            return new SuccessDataResult<List<BookType>>(_bookTypeDal.GetAll());
        }
        private IResult CheckIfBookNameExist(string typeName)
        {
            var result = _bookTypeDal.GetAll(x => x.Type == typeName).Any();
            if (result)
            {
                return new ErrorResult(Messages.CheckIfTypeNameExist);
            }
            return new SucessResult();
        
        }

    }
}
