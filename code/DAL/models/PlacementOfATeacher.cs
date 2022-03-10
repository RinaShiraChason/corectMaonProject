using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace DAL.models
{
    public partial class PlacementOfATeacher
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdPlacementOfATeacher")]

        public int IdPlacementOfATeacher { get; set; }
        public int? DayInWeek1M { get; set; }
        public int? DayInWeek1A { get; set; }
        public int? DayInWeek2M { get; set; }
        public int? DayInWeek2A { get; set; }
        public int? DayInWeek4M { get; set; }
        public int? DayInWeek4A { get; set; }
        public int? DayInWeek3M { get; set; }
        public int? DayInWeek3A { get; set; }
        public int? DayInWeek5M { get; set; }
        public int? DayInWeek5A { get; set; }
        public int? DayInWeek6M { get; set; }

 
        public int TeacherId { get; set; }
        public virtual User UserTeacher { get; set; }
    }
}
