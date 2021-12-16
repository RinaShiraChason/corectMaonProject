using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class PlacementOfATeacher
    {
        public int IdPlacementOfATeacher { get; set; }
        public string Shifts { get; set; }
        public DateTime DateShifts { get; set; }
        public int? ClassId { get; set; }
        public long? TeacherId { get; set; }

        public virtual Class Class { get; set; }
        public virtual TeacherAndManager Teacher { get; set; }
    }
}
