using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class PlacementOfATeacherDTO
    {
        public int IdPlacementOfATeacher { get; set; }
        public bool IsMorning { get; set; }
        public int DayInWeek { get; set; }
        public int ClassId { get; set; }
        public int TeacherId { get; set; }
        public  ClassesDTO Class { get; set; }
        public  UserDTO UserTeacher { get; set; }
    }
}
