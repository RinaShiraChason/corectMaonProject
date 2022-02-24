using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
   public class KidsAttendanceDAL
    {
        newMaonContext DB = new newMaonContext();
        public List<KidsAttendance> getAll()
        {
            return DB.KidsAttendances.ToList();
        }

        public bool update(KidsAttendance kidsAttendanceDal)
        {
            KidsAttendance k = DB.KidsAttendances.FirstOrDefault(x => x.AttendanceId == kidsAttendanceDal.AttendanceId);
            if (k != null)
            {
                k.CurrentDate = kidsAttendanceDal.CurrentDate;
                k.IsArrived = kidsAttendanceDal.IsArrived;
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

        public bool AddKids_Attendance(KidsAttendance kidsAttendanceDal)
        {
            DB.KidsAttendances.Add(kidsAttendanceDal);

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

        public bool Delete(int attendanceId)
        {
            KidsAttendance k = DB.KidsAttendances.FirstOrDefault(x => x.AttendanceId == attendanceId);

            DB.KidsAttendances.Remove(k);
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
