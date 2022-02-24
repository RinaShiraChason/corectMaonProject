using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DTO
{
    public class ImagesDTO
    {
   
        public int ImageId { get; set; }
        public string ImageURL { get; set; }
        public string ImageTitle { get; set; }
        public string ImageData { get; set; }
        public DateTime ImageDate { get; set; }
        public int? ClassId { get; set; }
        public int TeacherId { get; set; }
        public  ClassesDTO Class { get; set; }
        public  UserDTO UserTeacher { get; set; }
    }
}
