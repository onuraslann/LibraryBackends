using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Book:IEntity
    {
        public int Id { get; set; }
        public int WriterId { get; set; }
        public int BookTypeId { get; set; }
        public int Page { get; set; }
        public string BookName { get; set; }



    }
}
