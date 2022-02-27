using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
   public class PlacementOfATeacherDAL
    {
        newMaonContext DB = new newMaonContext();

        public List<PlacementOfATeacher> getAll()
        {
            return DB.PlacementOfATeachers.ToList();
        }

        public bool update(PlacementOfATeacher placement_Of_A_TeacherDAL)
        {
            PlacementOfATeacher tp = DB.PlacementOfATeachers.FirstOrDefault(x => x.IdPlacementOfATeacher == placement_Of_A_TeacherDAL.IdPlacementOfATeacher);
            if (tp != null)
            {
                 tp.IsMorning = placement_Of_A_TeacherDAL.IsMorning;
                tp.DayInWeek = placement_Of_A_TeacherDAL.DayInWeek;
                tp.ClassId = placement_Of_A_TeacherDAL.ClassId;
                tp.TeacherId = placement_Of_A_TeacherDAL.TeacherId;
           
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

        public bool AddPlacementOfATeacher(PlacementOfATeacher placement_Of_A_TeacherDAL)
        {
            DB.PlacementOfATeachers.Add(placement_Of_A_TeacherDAL);

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

        public bool Delete(int idPlacementOfATeacher)
        {
            PlacementOfATeacher k = DB.PlacementOfATeachers.FirstOrDefault(x => x.IdPlacementOfATeacher == idPlacementOfATeacher);

            DB.PlacementOfATeachers.Remove(k);
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
