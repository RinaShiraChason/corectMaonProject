using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Placement_Of_A_TeacherDTO
    {
        public int IdPlacementOfATeacher { get; set; }
        public string Shifts { get; set; }
        public DateTime DateShifts { get; set; }
        public int? ClassId { get; set; }
        public long? TeacherId { get; set; }
    }
}
