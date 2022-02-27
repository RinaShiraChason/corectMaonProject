using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DAL.models
{
    public partial class ActivityUpdate
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdActivityUpdate")]
        public int IdActivityUpdate { get; set; }
        public DateTime DailyActivityDate { get; set; }
        public string DailyActivitySubject { get; set; }
        public string DailyActivityInfo { get; set; }
        
        public int? ClassId { get; set; }
        public int TeacherId { get; set; }
        public virtual Class Class { get; set; }
        public virtual User UserTeacher { get; set; }
    }
}
