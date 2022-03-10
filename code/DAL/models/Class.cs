using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace DAL.models
{
    public partial class Class
    {
        public Class()
        {
            ActivityUpdates = new HashSet<ActivityUpdate>();
            Kids = new HashSet<Kid>();
            ExternalData= new HashSet<ExternalData>();
            Images = new HashSet<Images>();
            TeacherUsers = new HashSet<User>();



        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ClassId")]
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public int ClassTypeId { get; set; }


        public virtual TypeClass TypeClass { get; set; }
        public virtual ICollection<ActivityUpdate> ActivityUpdates { get; set; }
        public virtual ICollection<ExternalData> ExternalData { get; set; }
        public virtual ICollection<Images> Images { get; set; }
        public virtual ICollection<Kid> Kids { get; set; }
        public virtual ICollection<User> TeacherUsers { get; set; }
    }
}
