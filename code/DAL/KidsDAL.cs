using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class KidsDAL
    {
        newMaonContext DB = new newMaonContext();

        public List<Kid> getAll()
        {
            return DB.PlacementOfATeacher.ToList();
        }

        public bool uppdate(Kid kidDal)
        {
            Kid k = DB.PlacementOfATeacher.FirstOrDefault(x => x.TzKids == kidDal.TzKids);
            if (k != null)
            {
                //מה ששמתי בסוגרים לא שמים פה גם????---TzKids
                k.NameKids = kidDal.NameKids;
                k.AgeKids = kidDal.AgeKids;
                k.ClassId = kidDal.ClassId;
                k.DateBorn = kidDal.DateBorn;
                k.ParentsId = kidDal.ParentsId;
                k.AttendanceId = kidDal.AttendanceId;
                k.Attendance = kidDal.Attendance;
                k.Class = kidDal.Class;
                k.Parents = kidDal.Parents;
                
                try
                {
                    DB.SaveChanges();
                }
                catch
                {
                    return false;
                }
                

            }
            return true;

        }

        public bool AddKids(Kid kidDal)
        {
            DB.PlacementOfATeacher.Add(kidDal);
            
            try
            {
                DB.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

    }
}
