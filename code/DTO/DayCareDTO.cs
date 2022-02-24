using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DayCareDTO
    {
        public int IdDayCare { get; set; }
        public DateTime DateCare { get; set; }
        public string BehaviorDayCare { get; set; }
        public string DressDayCare { get; set; }
        public string CommentDayCare { get; set; }
        public string SleepDayCare { get; set; }
        public string FoodDayCare { get; set; }

        public int KidId { get; set; }
        public  KidsDTO Kid { get; set; }
    }
}
