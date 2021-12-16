using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class TeacherAndManager
    {
        public TeacherAndManager()
        {
            ActivityUpdates = new HashSet<ActivityUpdate>();
            PlacementOfATeachers = new HashSet<PlacementOfATeacher>();
            TypeEmployees = new HashSet<TypeEmployee>();
        }

        public long TeacherId { get; set; }
        public long TeacherTz { get; set; }
        public long? PersonTz { get; set; }

        public virtual Person PersonTzNavigation { get; set; }
        public virtual ICollection<ActivityUpdate> ActivityUpdates { get; set; }
        public virtual ICollection<PlacementOfATeacher> PlacementOfATeachers { get; set; }
        public virtual ICollection<TypeEmployee> TypeEmployees { get; set; }
    }
}
