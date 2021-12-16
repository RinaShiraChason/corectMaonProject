using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class DayCare
    {
        public int IdDayCare { get; set; }
        public string NameDayCare { get; set; }
        public int NumClasses { get; set; }
        public string DressDayCare { get; set; }
        public string AboutDayCare { get; set; }
    }
}
