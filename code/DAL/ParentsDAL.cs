using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
   public class ParentsDAL
    {
        newMaonContext DB = new newMaonContext();

        public List<Parent> getAll()
        {
            return DB.Parent.ToList();
        }

        public bool uppdate(Parent parentsDal)
        {
            Parent prt = DB.Parent.FirstOrDefault(x => x.ParentsId == parentsDal.ParentsId);
            if (prt != null)
            {
                prt.ParentsTz = parentsDal.ParentsTz;
                prt.PersonTz = parentsDal.PersonTz;
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

        public bool AddParents(Parent parentsDal)
        {
            DB.Parent.Add(parentsDal);

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
