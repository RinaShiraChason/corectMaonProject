using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
   public  class ActivityUpdateDTO
    {
        public int IdActivityUpdate { get; set; }
        public DateTime DailyActivityDate { get; set; }
        public string DailyActivitySubject { get; set; }
        public string DailyActivityInfo { get; set; }

        public int? ClassId { get; set; }
        public int TeacherId { get; set; }
        public  ClassesDTO Class { get; set; }
        public  UserDTO UserTeacher { get; set; }
    }
}
