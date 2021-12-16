using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class TypeClass
    {
        public int IdTypeClass { get; set; }
        public string TypeClassName { get; set; }
        public int? ClassId { get; set; }

        public virtual Class Class { get; set; }
    }
}
