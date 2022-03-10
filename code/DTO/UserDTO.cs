using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class UserDTO
    {
        public long UserId { get; set; }
        public string UserTz { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNamber1 { get; set; }
        public string PhoneNamber2 { get; set; }
        public string Password { get; set; }

        public int? ClassId { get; set; }
        public int UserTypeId { get; set; }
    }
}
