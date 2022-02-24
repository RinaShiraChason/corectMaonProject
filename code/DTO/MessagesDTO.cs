using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DTO
{
    public class MessagesDTO
    {
    
        public int MessageId { get; set; }
        public string MessageContent { get; set; }
        public DateTime MessageDateTime { get; set; }
        public int UserFromId { get; set; }
        public int KidId { get; set; }
        public int UserToId { get; set; }
        public  UserDTO UserFrom { get; set; }
        public  UserDTO UserTo { get; set; }
        public  KidsDTO Kid { get; set; }
    }
}
