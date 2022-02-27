using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace DAL.models
{
    public partial class User
    {
        public User()
        {
            ActivityUpdates = new HashSet<ActivityUpdate>();
            Kids = new HashSet<Kid>(); 
            ExternalData = new HashSet<ExternalData>();
            Images = new HashSet<Images>();
            MessagesFrom = new HashSet<Messages>();
            MessagesTo = new HashSet<Messages>();
            PlacementOfATeacher = new HashSet<PlacementOfATeacher>();
            RecoverLosts = new HashSet<RecoverLosts>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("UserId")]

        public int UserId { get; set; }
        public string UserTz { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNamber1 { get; set; }
        public string PhoneNamber2 { get; set; }
        public string Password { get; set; }
        public int UserTypeId { get; set; }
        public virtual ICollection<ActivityUpdate> ActivityUpdates { get; set; }
        public virtual ICollection<Kid> Kids { get; set; }
        public virtual ICollection<ExternalData> ExternalData { get; set; }
        public virtual ICollection<Images> Images { get; set; }
        public virtual ICollection<Messages> MessagesFrom { get; set; }
        public virtual ICollection<Messages> MessagesTo{ get; set; }
        public virtual ICollection<PlacementOfATeacher> PlacementOfATeacher { get; set; }
        public virtual ICollection<RecoverLosts> RecoverLosts { get; set; }


        

    }
}
