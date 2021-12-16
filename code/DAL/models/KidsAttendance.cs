using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class KidsAttendance
    {
        public KidsAttendance()
        {
            Kids = new HashSet<Kid>();
        }

        public int AttendanceId { get; set; }
        public int KidId { get; set; }
        public int ParentId { get; set; }
        public DateTime CurrentDate { get; set; }
        public bool Check { get; set; }

        public virtual ICollection<Kid> Kids { get; set; }
    }
}
