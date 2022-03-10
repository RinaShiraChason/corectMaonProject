using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class TypeClassDAL
    {


        public List<TypeClass> GetAll()
        {
            using (var db = new newMaonContext())
            {
                return db.TypeClasses.ToList();
            }
        }

        public bool update(TypeClass typeClassDal)
        {
            using (var db = new newMaonContext())
            {
                TypeClass k = db.TypeClasses.FirstOrDefault(x => x.IdTypeClass == typeClassDal.IdTypeClass);
                if (k != null)
                {

                    k.TypeClassName = typeClassDal.TypeClassName;
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
        public bool AddTypeClass(TypeClass typeClassDal)
        {
            using (var db = new newMaonContext())
            {
                db.TypeClasses.Add(typeClassDal);

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

        public bool Delete(int idTypeClass)
        {
            using (var db = new newMaonContext())
            {
                TypeClass k = db.TypeClasses.FirstOrDefault(x => x.IdTypeClass == idTypeClass);

                db.TypeClasses.Remove(k);
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
