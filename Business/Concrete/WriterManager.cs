using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public IResult Add(Writer writer)
        {
            _writerDal.Add(writer);
            return new SuccessResult();
        }

        public IDataResult<List<Writer>> GetAll()
        {
            return new SuccessDataResult<List<Writer>>(_writerDal.GetAll());
        }
    }
}
