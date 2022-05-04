using DAL.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ActivityUpdateDAL
    {


        public List<ActivityUpdate> GetAll()
        {
            using (var db = new newMaonContext())
            {
                return db.ActivityUpdates.ToList();
            }
        }
        public ActivityUpdate GetTodayActivityUpdateByClass(int classId)
        {
            var today = DateTime.Today;
            using (var db = new newMaonContext())
            {
                return db.ActivityUpdates.Include("UserTeacher").FirstOrDefault(x => x.ClassId == classId
                && x.DailyActivityDate.Date == today);
            }
        }

        public bool update(ActivityUpdate activityUpdateDal)
        {
            using (var db = new newMaonContext())
            {
                ActivityUpdate k = db.ActivityUpdates.FirstOrDefault(x => x.IdActivityUpdate == activityUpdateDal.IdActivityUpdate);
                if (k != null)
                {
                    k.DailyActivityDate = activityUpdateDal.DailyActivityDate;
                    k.DailyActivitySubject = activityUpdateDal.DailyActivitySubject;
                    k.DailyActivityInfo = activityUpdateDal.DailyActivityInfo;



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

        public bool AddActivityUpdate(ActivityUpdate ActivityUpdateDal)
        {
            using (var db = new newMaonContext())
            {
                db.ActivityUpdates.Add(ActivityUpdateDal);

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


        public bool Delete(int idActivityUpdate)
        {
            using (var db = new newMaonContext())
            {
                ActivityUpdate k = db.ActivityUpdates.FirstOrDefault(x => x.IdActivityUpdate == idActivityUpdate);

                db.ActivityUpdates.Remove(k);
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
