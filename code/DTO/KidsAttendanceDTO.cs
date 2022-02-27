using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class KidsAttendanceDTO
    {
        public int AttendanceId { get; set; }
        public DateTime CurrentDate { get; set; }
        public bool IsArrived { get; set; }
        public int KidId { get; set; }
        public  KidsDTO Kid { get; set; }

    }
}
