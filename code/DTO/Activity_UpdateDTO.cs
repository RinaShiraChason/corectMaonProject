using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
   public  class Activity_UpdateDTO
    {
        public int IdActivityUpdate { get; set; }
        public string WeeklyColumn { get; set; }
        public string Calendar { get; set; }
        public string DailyActivity { get; set; }
        public string LostSabbath { get; set; }
        public int? ClassId { get; set; }
        public long? TeacherId { get; set; }
    }
}
