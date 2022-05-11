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
        public List<Kid> GetKidsByClassID(int classId)
        {
            using (var db = new newMaonContext())
            {
                var kids = db.Kids.Include("Class").Include("UserParent").Where(x => x.ClassId == classId).ToList();

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
        //שליפת הדיווח היומי של הילד
        public List<Kid> GetTodayKidsData(int classId)
        {
            using (var db = new newMaonContext())
            {
                //שליפת הילדים שהיו בכיתה באותו יום
                var kids = db.Kids.Where(x => x.ClassId == classId).ToList();
                var lKidsIds = kids.Select(x => x.KidId).ToList();
                var dayCares = db.DayCares.Where(x => lKidsIds.Contains(x.KidId)
                && x.DateCare.Date == DateTime.Today).ToList();
                var kidsAttendences = db.KidsAttendances.Where(x => lKidsIds.Contains(x.KidId) && x.CurrentDate.Date == DateTime.Today).ToList();
                //עובר לפי ילד ושולף את כל הדיוח המתאים לאותו יום של הילד הנוכחי
                foreach (var kid in kids)
                {
                    kid.KidsAttendance = kidsAttendences.Where(x => x.KidId == kid.KidId).Select(x => new KidsAttendance() { IsArrived = x.IsArrived, CurrentDate = x.CurrentDate, AttendanceId = x.AttendanceId }).ToList();

                    kid.DayCare = dayCares.Where(x => x.KidId == kid.KidId).
                        Select(x => new DayCare()
                        {
                            CommentDayCare = x.CommentDayCare,
                            DateCare = x.DateCare,
                            BehaviorDayCare = x.BehaviorDayCare,
                            DressDayCare = x.DressDayCare,
                            FoodDayCare = x.FoodDayCare,
                            SleepDayCare = x.SleepDayCare,
                            IdDayCare = x.IdDayCare
                        }).ToList();
                }
                return kids;

            }
        }
        //שליפה ותצוגה של העדכונים היומיים לילד לחודש ושנה מסוים
        public Kid GetHistoryKidsData(int kidId, int month, int year)
        {
            using (var db = new newMaonContext())
            {
                //שליפת הימים בחודש
                var dayInMonth = DateTime.DaysInMonth(year, month);
                var kid = db.Kids.FirstOrDefault(x => x.KidId == kidId);
                // שליפת הפעילות היומית לכל החודש הנבחר
                var dayCares = db.DayCares.Where(x => x.KidId == kidId
                && x.DateCare.Month == month && x.DateCare.Year == year).ToList();
                //שליפת הנוכחות לילד לכל ימות החודש
                var kidsAttendences = db.KidsAttendances.Where(x => x.KidId == kidId
                && x.CurrentDate.Month == month && x.CurrentDate.Year == year).ToList();

                var lAtt = new List<KidsAttendance>();
                var lCare = new List<DayCare>();
                //ריצה על מספר הימים בחודש 
                for (int i = 1; i < dayInMonth; i++)
                {
                    //שליפת הנוכחות היומית לכל יום אם לא קיים מחזיר רשומה ריקה
                    var att = kidsAttendences.Where(x => x.CurrentDate.Day == i)
                        .Select(x => new KidsAttendance() { IsArrived = x.IsArrived, CurrentDate = x.CurrentDate }).FirstOrDefault();
                    att = att == null ? att = new KidsAttendance() { IsArrived = false, CurrentDate = new DateTime(year, month, i) } : att;
                    lAtt.Add(att);

                    //שליפת העדכון היומי לכל יום אם לא קיים מחזיר רשומה ריקה

                    var cre = dayCares.Where(x => x.DateCare.Day == i).Select(x => new DayCare()
                    {
                        CommentDayCare = x.CommentDayCare,
                        DateCare = x.DateCare,
                        BehaviorDayCare = x.BehaviorDayCare,
                        DressDayCare = x.DressDayCare,
                        FoodDayCare = x.FoodDayCare,
                        SleepDayCare = x.SleepDayCare
                    }).FirstOrDefault();
                    cre = cre == null ? cre = new DayCare()
                    {
                        DateCare = new DateTime(year, month, i),
                    } : cre;
                    lCare.Add(cre);
                }
                //החזרת הילד עם התת נתונים שלו * ימות החודש
                kid.DayCare = lCare;
                kid.KidsAttendance = lAtt;
                return kid;

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

        public bool AddUpdateKid(Kid kidDal)
        {
            using (var db = new newMaonContext())
            {
                var parent = kidDal.UserParent;
                if (parent.UserId == 0)
                {
                    db.Users.Add(parent);


                }

                else
                {
                    var p = db.Users.FirstOrDefault(x => x.UserId == kidDal.UserParent.UserId);
                    p.UserName = parent.UserName;
                    p.Address = parent.Address;
                    p.Email = parent.Email;
                    p.PhoneNamber1 = parent.PhoneNamber1;
                    p.PhoneNamber2 = parent.PhoneNamber2;
                    p.UserTz = parent.UserTz;
                }

                try
                {
                    db.SaveChanges();
                }
                catch
                {
                    return false;
                }

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
                else
                {
                    kidDal.UserParent = null;
                    kidDal.ParentId = parent.UserId;
                    db.Kids.Add(kidDal);

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



    }
}
