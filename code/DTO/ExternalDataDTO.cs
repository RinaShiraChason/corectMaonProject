using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DTO
{
    public class ExternalDataDTO
    {
     
        public int ExternalDataId { get; set; }
        public string ExternalDataTitle { get; set; }
        public string ExternalDataLink { get; set; }
        public DateTime ExternalDataDate { get; set; }
        public int? ClassId { get; set; }
        public int TeacherId { get; set; }

        public  ClassesDTO Class { get; set; }
        public  UserDTO UserTeacher { get; set; }
    }
}
