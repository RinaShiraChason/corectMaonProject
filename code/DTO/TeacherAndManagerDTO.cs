using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TeacherAndManagerDTO
    {
        public long TeacherId { get; set; }
        public long TeacherTz { get; set; }
        public long? PersonTz { get; set; }
        public PersonDTO myPerson { get; set; }

    }
}
