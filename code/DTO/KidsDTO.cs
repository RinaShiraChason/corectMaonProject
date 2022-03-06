using System;

namespace DTO
{
    public class KidsDTO
    {
        public int KidId { get; set; }
        public string NameKids { get; set; }
        public string TzKid { get; set; }
        public float AgeKids { get; set; }
        public int ClassId { get; set; }
        public DateTime DateBorn { get; set; }
        public int ParentId { get; set; }


        public  ClassesDTO Class { get; set; }
        public  UserDTO UserParent { get; set; }

    }
}
