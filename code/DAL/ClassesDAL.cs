using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ClassesDAL
    {

        public List<Class> GetAll()
        {
            using (var db = new newMaonContext())
            {
                return db.Classes.ToList();
            }
        }

        public bool update(Class classDal)
        {
            using (var db = new newMaonContext())
            {
                Class k = db.Classes.FirstOrDefault(x => x.ClassId == classDal.ClassId);
                if (k != null)
                {

                    k.ClassName = classDal.ClassName;
                    k.ClassTypeId = classDal.ClassTypeId;

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

        public bool AddClasses(Class ClassDal)
        {
            using (var db = new newMaonContext())
            {
                db.Classes.Add(ClassDal);

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

        public bool Delete(int classId)
        {
            using (var db = new newMaonContext())
            {
                Class k = db.Classes.FirstOrDefault(x => x.ClassId == classId);

                db.Classes.Remove(k);
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
