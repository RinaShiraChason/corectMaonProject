using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Activity_UpdateDAL
    {
        newMaonContext DB = new newMaonContext();

        public List<ActivityUpdate> getAll()
        {
            return DB.ActivityUpdates.ToList();
        }

        public bool uppdate(ActivityUpdate activityUpdateDal)
        {
            ActivityUpdate k = DB.ActivityUpdates.FirstOrDefault(x => x.IdActivityUpdate == activityUpdateDal.IdActivityUpdate);
            if (k != null)
            {
                k.IdActivityUpdate = activityUpdateDal.IdActivityUpdate;
                k.WeeklyColumn = activityUpdateDal.WeeklyColumn;
                k.Calendar = activityUpdateDal.Calendar;
                k.DailyActivity = activityUpdateDal.DailyActivity;
                k.LostSabbath = activityUpdateDal.LostSabbath;
                k.ClassId = activityUpdateDal.ClassId;
                k.TeacherId = activityUpdateDal.TeacherId;
                k.Class = activityUpdateDal.Class;
                k.Teacher = activityUpdateDal.Teacher;

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

        public bool AddActivity_Update(ActivityUpdate ActivityUpdateDal)
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
    }
}
