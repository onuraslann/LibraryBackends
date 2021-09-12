using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookTypeDal : EntityRepositoryBase<Book, LibraryContext>, IBookDal
    {
        public List<BookDtoDetails> GetBtDto()
        {
            using (LibraryContext context = new LibraryContext())
            {
                var result = from booktype in context.BookTypes
                             join book in context.Books
                             on booktype.Id equals book.BookTypeId
                             join writer in context.Writers
                             on book.WriterId equals writer.Id
                             select new BookDtoDetails
                             {
                                 WriterFirstName = writer.WriterFirstName,
                                 WriterLastName = writer.WriterLastName,
                                 Type = booktype.Type,
                                 BookName = book.BookName,
                                 Page = book.Page

                             };
                return result.ToList();
            }
        }
    }
}
