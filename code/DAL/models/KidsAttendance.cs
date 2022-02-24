using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace DAL.models
{
    public partial class KidsAttendance
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("AttendanceId")]

        public int AttendanceId { get; set; }
        public DateTime CurrentDate { get; set; }
        public bool IsArrived { get; set; }
        public int KidId { get; set; }
        public virtual Kid Kid { get; set; }
    }
}
