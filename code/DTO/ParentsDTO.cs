using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ParentsDTO
    {
        public long ParentsId { get; set; }
        public long ParentsTz { get; set; }
        public long? PersonTz { get; set; }

        public PersonDTO myPerson { get; set; }

    }
}
