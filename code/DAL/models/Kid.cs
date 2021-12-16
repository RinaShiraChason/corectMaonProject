using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class Kid
    {
        public long TzKids { get; set; }
        public string NameKids { get; set; }
        public double AgeKids { get; set; }
        public int? ClassId { get; set; }
        public DateTime DateBorn { get; set; }
         public long? ParentsId { get; set; }
        public int? AttendanceId { get; set; }

        public virtual KidsAttendance Attendance { get; set; }
        public virtual Class Class { get; set; }
        public virtual Parent Parents { get; set; }
    }
}
