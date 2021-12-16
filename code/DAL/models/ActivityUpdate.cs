using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class ActivityUpdate
    {
        public int IdActivityUpdate { get; set; }
        public string WeeklyColumn { get; set; }
        public string Calendar { get; set; }
        public string DailyActivity { get; set; }
        public string LostSabbath { get; set; }
        public int? ClassId { get; set; }
        public long? TeacherId { get; set; }

        public virtual Class Class { get; set; }
        public virtual TeacherAndManager Teacher { get; set; }
    }
}
