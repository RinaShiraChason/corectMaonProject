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

        public bool update(Class classDal)
        {
            Class k = DB.Classes.FirstOrDefault(x => x.ClassId == classDal.ClassId);
            if (k != null)
            {
           
                k.ClassName = classDal.ClassName;
                k.ClassTypeId = classDal.ClassTypeId;

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
