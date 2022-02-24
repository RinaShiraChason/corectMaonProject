using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace DAL.models
{
    public partial class DayCare
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdDayCare")]

        public int IdDayCare { get; set; }
        public DateTime DateCare { get; set; }
        public string BehaviorDayCare { get; set; }
        public string DressDayCare { get; set; }
        public string CommentDayCare { get; set; }
        public string SleepDayCare { get; set; }
        public string FoodDayCare { get; set; }

        public int KidId { get; set; }
        public virtual Kid Kid { get; set; }
    }
}
