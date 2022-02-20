using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ClassesDAL
    {
        newMaonContext DB = new newMaonContext();
        public List<Class> getAll()
        {
            return DB.Classes.ToList();
        }

        public bool uppdate(Class classDal)
        {
            Class k = DB.Classes.FirstOrDefault(x => x.ClassId == classDal.ClassId);
            if (k != null)
            {
                k.ClassId = classDal.ClassId;
                k.KindOfClassId = classDal.KindOfClassId;
                k.ActivityUpdates = classDal.ActivityUpdates;
                k.Kids = classDal.Kids;
                k.PlacementOfATeachers = classDal.PlacementOfATeachers;
                k.TypeClasses = classDal.TypeClasses;
                
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

        public bool AddClasses(Class ClassDal)
        {
            DB.Classes.Add(ClassDal);

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

        public bool Delete(int classId)
        {
            Class k = DB.Classes.FirstOrDefault(x => x.ClassId == classId);

            DB.Classes.Remove(k);
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
