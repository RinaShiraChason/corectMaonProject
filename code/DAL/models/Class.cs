using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class Class
    {
        public Class()
        {
            ActivityUpdates = new HashSet<ActivityUpdate>();
            Kids = new HashSet<Kid>();
            PlacementOfATeachers = new HashSet<PlacementOfATeacher>();
            TypeClasses = new HashSet<TypeClass>();
        }

        public int ClassId { get; set; }
        public int KindOfClassId { get; set; }

        public virtual ICollection<ActivityUpdate> ActivityUpdates { get; set; }
        public virtual ICollection<Kid> Kids { get; set; }
        public virtual ICollection<PlacementOfATeacher> PlacementOfATeachers { get; set; }
        public virtual ICollection<TypeClass> TypeClasses { get; set; }
    }
}
