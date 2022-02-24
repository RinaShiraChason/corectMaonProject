using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class TypeClassDAL
    {
        newMaonContext DB = new newMaonContext();

        public List<TypeClass> getAll()
        {
            return DB.TypeClasses.ToList();
        }

        public bool update(TypeClass typeClassDal)
        {
            TypeClass k = DB.TypeClasses.FirstOrDefault(x => x.IdTypeClass == typeClassDal.IdTypeClass);
            if (k != null)
            {

                 k.TypeClassName = typeClassDal.TypeClassName;
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

        public bool AddTypeClass(TypeClass typeClassDal)
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
