using Business.Abstract;
using Business.Constants;
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
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        [ValidationAspect(typeof(StudentValidator))]
        public IResult Add(Student student)
        {
            _studentDal.Add(student);
            return new SuccessResult(Messages.StudentAdded);
        }

        public IResult Delete(Student student)
        {
            _studentDal.Delete(student);
            return new SuccessResult(Messages.StudentDeleted);
        }

        public IDataResult<List<Student>> GetAll()
        {
            return new SuccessDataResult<List<Student>>(_studentDal.GetAll());
        }
    }
}
