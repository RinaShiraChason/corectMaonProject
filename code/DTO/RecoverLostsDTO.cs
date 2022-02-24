using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DTO
{
    public class RecoverLostsDTO
    {
     
        public int RecoverLostsId { get; set; }
        public string RecoverLostsInfo { get; set; }
        public string RecoverLostsImage { get; set; }
        public DateTime RecoverLostsDate { get; set; }
        public int IdUser { get; set; }
        public  UserDTO User { get; set; }
    }
}
