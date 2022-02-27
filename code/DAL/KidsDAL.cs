using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class KidsDAL
    {
        newMaonContext DB = new newMaonContext();

        public List<Kid> getAll()
        {
            return DB.Kids.ToList();
        }

        public bool update(Kid kidDal)
        {
            Kid k = DB.Kids.FirstOrDefault(x => x.KidId == kidDal.KidId);
            if (k != null)
            {
                
                k.NameKids = kidDal.NameKids;
                k.AgeKids = kidDal.AgeKids;
                k.ClassId = kidDal.ClassId;
                k.DateBorn = kidDal.DateBorn;
                k.TzKid = kidDal.TzKid;
       
            
                
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

        public bool Delete(long tz)
        {

            Kid k = DB.Kids.FirstOrDefault(x => x.KidId == tz);

            DB.Kids.Remove(k);
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

        public bool AddKids(Kid kidDal)
        {
            DB.Kids.Add(kidDal);
            
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
