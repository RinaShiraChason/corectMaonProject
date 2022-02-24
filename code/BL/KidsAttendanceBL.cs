using AutoMapper;
using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class KidsAttendanceBL
    {
        IMapper imapper;
        KidsAttendanceDAL _kids_AttendanceDal = new KidsAttendanceDAL();

        public KidsAttendanceBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            });
            imapper = config.CreateMapper();
        }

        public List<KidsAttendanceDTO> getAll()
        {
            List<KidsAttendance> l = _kids_AttendanceDal.getAll();
            List<KidsAttendanceDTO> lDTO = imapper.Map<List<KidsAttendance>, List<KidsAttendanceDTO>>(l);
            return lDTO;
        }

        public bool update(KidsAttendanceDTO kids_Attendance)
        {
            KidsAttendance KidsAttendanceDal = imapper.Map<KidsAttendanceDTO, KidsAttendance>(kids_Attendance);
            bool b = _kids_AttendanceDal.update(KidsAttendanceDal);

            return b;
        }

        public object Delete(int attendanceId)
        {
            bool b = _kids_AttendanceDal.Delete(attendanceId);

            return b;
        }

        public bool AddKids_Attendance(KidsAttendanceDTO kids_Attendance)
        {
            KidsAttendance KidsAttendanceDal = imapper.Map<KidsAttendanceDTO, KidsAttendance>(kids_Attendance);
            bool b = _kids_AttendanceDal.AddKids_Attendance(KidsAttendanceDal);

            return b;
        }

    }
}
