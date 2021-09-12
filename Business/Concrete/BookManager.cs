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
    public class BookManager : IBookService
    {
        IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public IResult Add(Book book)
        {
            _bookDal.Add(book);
            return new SucessResult(Messages.BookAdded);
        }

        public IDataResult<List<Book>> GetAll()
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(), Messages.BookList);
        }

        public IDataResult<List<Book>> GetByPage(int page)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(x=> x.Page>page));
        }

        public IDataResult<List<Book>> GetByType(int type)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(x => x.BookTypeId ==type));
        }
    }
}
