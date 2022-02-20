using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Kids_AttendanceDTO
    {
        public int AttendanceId { get; set; }
        public int KidId { get; set; }
        public int ParentId { get; set; }
        public DateTime CurrentDate { get; set; }
        public bool Check { get; set; }

    }
}
