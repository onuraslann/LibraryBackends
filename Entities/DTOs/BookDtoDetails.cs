using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
  public  class BookDtoDetails
    {
        public string Type { get; set; }
        public int Page { get; set; }

        public string BookName { get; set; }

        public string WriterFirstName { get; set; }

        public string WriterLastName { get; set; }
    }
}
