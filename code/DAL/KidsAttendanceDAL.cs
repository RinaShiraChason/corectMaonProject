using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class KidsAttendanceDAL
    {

        public List<KidsAttendance> GetAll()
        {
            using (var db = new newMaonContext())
            {
                return db.KidsAttendances.ToList();
            }
        }

        public bool update(KidsAttendance kidsAttendanceDal)
        {
            using (var db = new newMaonContext())
            {
                KidsAttendance k = db.KidsAttendances.FirstOrDefault(x => x.AttendanceId == kidsAttendanceDal.AttendanceId);
                if (k != null)
                {
                    k.CurrentDate = kidsAttendanceDal.CurrentDate;
                    k.IsArrived = kidsAttendanceDal.IsArrived;
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

        public bool AddKids_Attendance(KidsAttendance kidsAttendanceDal)
        {
            using (var db = new newMaonContext())
            {
                db.KidsAttendances.Add(kidsAttendanceDal);

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

        public bool Delete(int attendanceId)
        {
            using (var db = new newMaonContext())
            {
                KidsAttendance k = db.KidsAttendances.FirstOrDefault(x => x.AttendanceId == attendanceId);

                db.KidsAttendances.Remove(k);
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

        public bool SetKidAttendence(KidsAttendance kidsAttendanceDal)
        {
            using (var db = new newMaonContext())
            {
                KidsAttendance k = db.KidsAttendances.FirstOrDefault(x => x.KidId == kidsAttendanceDal.KidId && x.CurrentDate.Date == DateTime.Today);
                if (k != null)
                {
                    k.CurrentDate = DateTime.Now;
                    k.IsArrived = kidsAttendanceDal.IsArrived;
                }
                else
                {
                    k = new KidsAttendance();
                    k.KidId = kidsAttendanceDal.KidId;
                    k.CurrentDate = DateTime.Now;
                    k.IsArrived = true;
                    db.KidsAttendances.Add(k);

                }
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
