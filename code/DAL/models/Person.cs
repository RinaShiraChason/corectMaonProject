using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class Person
    {
        public Person()
        {
            Parents = new HashSet<Parent>();
            TeacherAndManagers = new HashSet<TeacherAndManager>();
        }

        public long PersonTz { get; set; }
        public string PersonName { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string PhoneNamber1 { get; set; }
        public string PhoneNamber2 { get; set; }

        public virtual ICollection<Parent> Parents { get; set; }
        public virtual ICollection<TeacherAndManager> TeacherAndManagers { get; set; }
    }
}
