using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface IBookService
    {
        IDataResult<List<Book>> GetAll();
        IDataResult<List<Book>> GetByType(int type);
       IDataResult<List<Book>>GetByPage(int page);

        IResult Add(Book book);

    }
}
