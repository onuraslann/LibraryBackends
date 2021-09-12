using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBookTypeService
    {
        IDataResult<List<BookType>> GetAll();
        IResult Add(BookType bookType);
        IResult Delete(BookType bookType);
    }
}
