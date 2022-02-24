using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ClassesDTO
    {

        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public int ClassTypeId { get; set; }


        public  TypeClassDTO TypeClass { get; set; }
    }
}
