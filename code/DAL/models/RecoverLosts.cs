using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DAL.models
{
    public class RecoverLosts
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("RecoverLostsId")]

        public int RecoverLostsId { get; set; }
        public string RecoverLostsInfo { get; set; }
        public string RecoverLostsImage { get; set; }
        public DateTime RecoverLostsDate { get; set; }
        public int IdUser { get; set; }
        public virtual User User { get; set; }
    }
}
