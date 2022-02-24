using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DAL.models
{
    public class ExternalData
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ExternalDataId")]

        public int ExternalDataId { get; set; }
        public string ExternalDataTitle { get; set; }
        public string ExternalDataLink { get; set; }
        public DateTime ExternalDataDate { get; set; }
        public int? ClassId { get; set; }
        public int TeacherId { get; set; }

        public virtual Class Class { get; set; }
        public virtual User UserTeacher { get; set; }
    }
}
