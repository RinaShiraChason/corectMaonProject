
using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace DAL.models
{
    public partial class Kid
    {
        public Kid()
        {
            DayCare = new HashSet<DayCare>();
            KidsAttendance = new HashSet<KidsAttendance>();
            Messages = new HashSet<Messages>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("KidId")]

        public int KidId { get; set; }
        public string NameKids { get; set; }
        public string TzKid { get; set; }
        public float AgeKids { get; set; }
        public int ClassId { get; set; }
        public DateTime DateBorn { get; set; }
         public int ParentId { get; set; }


        public virtual Class Class { get; set; }
        public virtual User UserParent { get; set; }

        public virtual ICollection<Messages> Messages { get; set; }
        public virtual ICollection<DayCare> DayCare { get; set; }
        public virtual ICollection<KidsAttendance> KidsAttendance { get; set; }
    }
}
