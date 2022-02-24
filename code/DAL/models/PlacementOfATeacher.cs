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
        public bool IsMorning { get; set; }
        public int DayInWeek { get; set; }
        public int ClassId { get; set; }
        public int TeacherId { get; set; }
        public virtual Class Class { get; set; }
        public virtual User UserTeacher { get; set; }
    }
}
