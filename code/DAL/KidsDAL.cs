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

        public bool uppdate(Kid kidDal)
        {
            Kid k = DB.Kids.FirstOrDefault(x => x.TzKids == kidDal.TzKids);
            if (k != null)
            {
                k.NameKids = kidDal.NameKids;
                k.Attendance = kidDal.Attendance;
                //ליעכג
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
