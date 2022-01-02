using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
   public class Placement_Of_A_TeacherDAL
    {
        newMaonContext DB = new newMaonContext();

        public List<PlacementOfATeacher> getAll()
        {
            return DB.PlacementOfATeacher.ToList();
        }

        public bool uppdate(PlacementOfATeacher placement_Of_A_TeacherDAL)
        {
            PlacementOfATeacher tp = DB.PlacementOfATeacher.FirstOrDefault(x => x.IdPlacementOfATeacher == placement_Of_A_TeacherDAL.IdPlacementOfATeacher);
            if (tp != null)
            {
                tp.IdPlacementOfATeacher = Placement_Of_A_TeacherDAL.IdPlacementOfATeacher;
                tp.Shifts = Placement_Of_A_TeacherDAL.Shifts;
                tp.DateShifts = Placement_Of_A_TeacherDAL.DateShifts;
                tp.ClassId = Placement_Of_A_TeacherDAL.ClassId;
                tp.TeacherId = Placement_Of_A_TeacherDAL.TeacherId;

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
            DB.PlacementOfATeacher.Add(placement_Of_A_TeacherDAL);

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
