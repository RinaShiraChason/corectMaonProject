using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DAL.models
{
    public class Messages
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("MessageId")]

        public int MessageId { get; set; }
        public string MessageContent { get; set; }
        public DateTime MessageDateTime { get; set; }
        public int UserFromId { get; set; }
        public int KidId { get; set; }
        public int UserToId { get; set; }
        public virtual User UserFrom { get; set; }
        public virtual User UserTo { get; set; }
        public virtual Kid Kid { get; set; }
    }
}
