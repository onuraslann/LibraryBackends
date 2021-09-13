using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Operation:IEntity
    {

        public int Id { get; set; }
        public int StudentId { get; set; }
        public int BookId { get; set; }
        public int Price { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
