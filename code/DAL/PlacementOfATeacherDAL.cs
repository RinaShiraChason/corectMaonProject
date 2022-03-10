using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class PlacementOfATeacherDAL
    {


        public List<PlacementOfATeacher> GetAll()
        {
            using (var db = new newMaonContext())
            {
                return db.PlacementOfATeachers.ToList();
            }
        }
        public PlacementOfATeacher GetByTeacherId(int id)
        {
            using (var db = new newMaonContext())
            {
                return db.PlacementOfATeachers.FirstOrDefault(x => x.TeacherId == id);
            }
        }

        public bool update(PlacementOfATeacher placement_Of_A_TeacherDAL)
        {
            using (var db = new newMaonContext())
            {
                PlacementOfATeacher tp = db.PlacementOfATeachers.FirstOrDefault(x => x.IdPlacementOfATeacher == placement_Of_A_TeacherDAL.IdPlacementOfATeacher);
                if (tp != null)
                {
                    tp.DayInWeek1A = placement_Of_A_TeacherDAL.DayInWeek1A;
                    tp.DayInWeek1M = placement_Of_A_TeacherDAL.DayInWeek1M;


                    tp.DayInWeek2A = placement_Of_A_TeacherDAL.DayInWeek2A;
                    tp.DayInWeek3A = placement_Of_A_TeacherDAL.DayInWeek3A;
                    tp.DayInWeek4A = placement_Of_A_TeacherDAL.DayInWeek4A;
                    tp.DayInWeek5A = placement_Of_A_TeacherDAL.DayInWeek5A;
                    tp.DayInWeek2M = placement_Of_A_TeacherDAL.DayInWeek2M;
                    tp.DayInWeek3M = placement_Of_A_TeacherDAL.DayInWeek3M;
                    tp.DayInWeek4M = placement_Of_A_TeacherDAL.DayInWeek4M;
                    tp.DayInWeek5M = placement_Of_A_TeacherDAL.DayInWeek5M;
                    tp.DayInWeek6M = placement_Of_A_TeacherDAL.DayInWeek6M;
                    try
                    {
                        db.SaveChanges();
                    }
                    catch
                    {
                        return false;
                    }


                }
                return true;
            }
        }

        public bool AddPlacementOfATeacher(PlacementOfATeacher placement_Of_A_TeacherDAL)
        {
            using (var db = new newMaonContext())
            {
                db.PlacementOfATeachers.Add(placement_Of_A_TeacherDAL);

                try
                {
                    db.SaveChanges();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

        public bool Delete(int idPlacementOfATeacher)
        {
            using (var db = new newMaonContext())
            {
                PlacementOfATeacher k = db.PlacementOfATeachers.FirstOrDefault(x => x.IdPlacementOfATeacher == idPlacementOfATeacher);

                db.PlacementOfATeachers.Remove(k);
                try
                {
                    db.SaveChanges();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }
    }
}   
