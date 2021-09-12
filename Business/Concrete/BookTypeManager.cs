using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
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
    }
}
