using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ActivityUpdateDAL
    {
        newMaonContext DB = new newMaonContext();

        public List<ActivityUpdate> getAll()
        {
            return DB.ActivityUpdates.ToList();
        }

        public bool update(ActivityUpdate activityUpdateDal)
        {
            ActivityUpdate k = DB.ActivityUpdates.FirstOrDefault(x => x.IdActivityUpdate == activityUpdateDal.IdActivityUpdate);
            if (k != null)
            {
                k.DailyActivityDate = activityUpdateDal.DailyActivityDate;
                k.DailyActivitySubject = activityUpdateDal.DailyActivitySubject;
                k.DailyActivityInfo = activityUpdateDal.DailyActivityInfo;

            

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

        public bool AddActivityUpdate(ActivityUpdate ActivityUpdateDal)
        {
            DB.ActivityUpdates.Add(ActivityUpdateDal);

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


        public bool Delete(int idActivityUpdate)
        {
            ActivityUpdate k = DB.ActivityUpdates.FirstOrDefault(x => x.IdActivityUpdate == idActivityUpdate);

            DB.ActivityUpdates.Remove(k);
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
