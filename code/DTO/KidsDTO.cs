using System;

namespace DTO
{
    public class KidsDTO
    {
        public long TzKids { get; set; }
        public string NameKids { get; set; }
        public double AgeKids { get; set; }
        public int? ClassId { get; set; }
        public DateTime DateBorn { get; set; }
        public long? ParentsId { get; set; }
        public int? AttendanceId { get; set; }

    }
}
