using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class Parent
    {
        public Parent()
        {
            Kids = new HashSet<Kid>();
        }

        public long ParentsId { get; set; }
        public long ParentsTz { get; set; }
        public long? PersonTz { get; set; }

        public virtual Person PersonTzNavigation { get; set; }
        public virtual ICollection<Kid> Kids { get; set; }
    }
}
