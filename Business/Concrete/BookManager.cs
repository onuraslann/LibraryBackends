using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Validation;
using Core.Utilities.Business;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        [ValidationAspect(typeof(BookValidator))]
        public IResult Add(Book book)
        {
            IResult result = BusinessRules.Run(CheckIfBookTypeCount(book.BookTypeId));
            if (result != null)
            {
                return result;
            }
            _bookDal.Add(book);
            return new SuccessResult(Messages.BookAdded);
        }

        public IDataResult<List<Book>> GetAll()
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(), Messages.BookList);
        }

        public IDataResult<List<BookDtoDetails>> GetByDto()
        {
            return new SuccessDataResult<List<BookDtoDetails>>(_bookDal.GetByDto(),Messages.BookDto);
        }

        public IDataResult<List<Book>> GetByPage(int page)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(x=> x.Page>page));
        }

        public IDataResult<List<Book>> GetByType(int type)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(x => x.BookTypeId ==type));
        }
        private IResult CheckIfBookTypeCount(int booktype)
        {
            var result = _bookDal.GetAll(x => x.BookTypeId == booktype).Count;
            if (result > 10)
            {
                return new ErrorResult(Messages.CheckIfBookType);
            }
            return new SuccessResult();
        }
    }
}
