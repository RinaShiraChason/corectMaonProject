using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace DAL.models
{
    public partial class TypeClass
    {
        public TypeClass()
        {
            Class = new HashSet<Class>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdTypeClass")]

        public int IdTypeClass { get; set; }
        public string TypeClassName { get; set; }
        public virtual ICollection<Class> Class { get; set; }   
    }
}
