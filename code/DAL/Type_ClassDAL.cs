using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Type_ClassDAL
    {
        newMaonContext DB = new newMaonContext();

        public List<TypeClass> getAll()
        {
            return DB.TypeClasses.ToList();
        }

        public bool uppdate(TypeClass typeClassDal)
        {
            TypeClass k = DB.TypeClasses.FirstOrDefault(x => x.IdTypeClass == typeClassDal.IdTypeClass);
            if (k != null)
            {

                k.IdTypeClass = typeClassDal.IdTypeClass;
                k.TypeClassName = typeClassDal.TypeClassName;
                k.ClassId = typeClassDal.ClassId;
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

        public bool AddType_Class(TypeClass typeClassDal)
        {
            DB.TypeClasses.Add(typeClassDal);

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

        public bool Delete(int idTypeClass)
        {
            TypeClass k = DB.TypeClasses.FirstOrDefault(x => x.IdTypeClass == idTypeClass);

            DB.TypeClasses.Remove(k);
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
