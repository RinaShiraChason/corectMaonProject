using DAL.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class KidsDAL
    {


        public List<Kid> GetAll()
        {
            using (var db = new newMaonContext())
            {
                return db.Kids.ToList();
            }
        }
        public List<Kid> GetAllByTeacherId(int teacherId)
        {
            using (var db = new newMaonContext())
            {
                var classID = db.Users.FirstOrDefault(x => x.UserId == teacherId).ClassId;
                var kids = db.Kids.Include("Class").Include("UserParent").Where(x => x.ClassId == classID).ToList();

                return kids;

            }

        }

        public bool update(Kid kidDal)
        {
            using (var db = new newMaonContext())
            {
                Kid k = db.Kids.FirstOrDefault(x => x.KidId == kidDal.KidId);
                if (k != null)
                {

                    k.NameKids = kidDal.NameKids;
                    k.AgeKids = kidDal.AgeKids;
                    k.ClassId = kidDal.ClassId;
                    k.DateBorn = kidDal.DateBorn;
                    k.TzKid = kidDal.TzKid;



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

        public List<Kid> GetTodayKidsWithAttendenc(int classId)
        {
            using (var db = new newMaonContext())
            {

                var kids = db.Kids.Where(x => x.ClassId == classId).ToList();
                var lKidsIds = kids.Select(x => x.KidId).ToList();
                var kidsAttendences = db.KidsAttendances.Where(x => lKidsIds.Contains(x.KidId) && x.CurrentDate.Date == DateTime.Today).ToList();
                foreach (var kid in kids)
                {
                    kid.KidsAttendance = kidsAttendences.Where(x => x.KidId == kid.KidId).Select(x => new KidsAttendance() { IsArrived = x.IsArrived, CurrentDate = x.CurrentDate }).ToList();
                }
                return kids;

            }
        }

        public List<Kid> GetTodayKidsWithDayCare(int classId)
        {
            using (var db = new newMaonContext())
            {

                var kids = db.Kids.Where(x => x.ClassId == classId).ToList();
                var lKidsIds = kids.Select(x => x.KidId).ToList();
                var dayCares = db.DayCares.Where(x => lKidsIds.Contains(x.KidId)
                && x.DateCare.Date == DateTime.Today).ToList();
                foreach (var kid in kids)
                {
                    kid.DayCare = dayCares.Where(x => x.KidId == kid.KidId).
                        Select(x => new DayCare()
                        {
                            CommentDayCare = x.CommentDayCare,
                            DateCare = x.DateCare,
                            BehaviorDayCare = x.BehaviorDayCare,
                            DressDayCare = x.DressDayCare,
                            FoodDayCare = x.FoodDayCare,
                            SleepDayCare = x.SleepDayCare
                        }).ToList();
                }
                return kids;

            }
        }


        public bool Delete(long tz)
        {
            using (var db = new newMaonContext())
            {
                Kid k = db.Kids.FirstOrDefault(x => x.KidId == tz);

                db.Kids.Remove(k);
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
        public bool AddKids(Kid kidDal)
        {
            using (var db = new newMaonContext())
            {
                db.Kids.Add(kidDal);

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
