using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Writer:IEntity
    {

        public int Id { get; set; }

        public string WriterFirstName { get; set; }

        public string WriterLastName { get; set; }
    }
}
