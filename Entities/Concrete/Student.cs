using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Student: IEntity
    {

        public int Id { get; set; }
        public int Age { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }   
    }
}
