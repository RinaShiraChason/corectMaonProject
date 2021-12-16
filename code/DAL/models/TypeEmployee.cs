using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class TypeEmployee
    {
        public int IdTypeEmp { get; set; }
        public string TypeEmpName { get; set; }
        public long? TeacherId { get; set; }

        public virtual TeacherAndManager Teacher { get; set; }
    }
}
