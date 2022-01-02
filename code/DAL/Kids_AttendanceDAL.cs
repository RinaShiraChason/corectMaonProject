using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
   public class Kids_AttendanceDAL
    {
        newMaonContext DB = new newMaonContext();
        public List<KidsAttendance> getAll()
        {
            return DB.KidsAttendances.ToList();
        }

        public bool uppdate(KidsAttendance kidsAttendanceDal)
        {
            KidsAttendance k = DB.KidsAttendances.FirstOrDefault(x => x.AttendanceId == kidsAttendanceDal.AttendanceId);
            if (k != null)
            {
                k.AttendanceId = kidsAttendanceDal.AttendanceId;
                k.KidId = kidsAttendanceDal.KidId;
                k.ParentId = kidsAttendanceDal.ParentId;
                k.CurrentDate = kidsAttendanceDal.CurrentDate;
                k.Check = kidsAttendanceDal.Check;
                k.Kids = kidsAttendanceDal.Kids;
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

    }
}
