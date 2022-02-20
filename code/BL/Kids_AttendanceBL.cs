using AutoMapper;
using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class Kids_AttendanceBL
    {
        IMapper imapper;
        Kids_AttendanceDAL _kids_AttendanceDal = new Kids_AttendanceDAL();

        public Kids_AttendanceBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            });
            imapper = config.CreateMapper();
        }

        public List<Kids_AttendanceDTO> getAll()
        {
            List<KidsAttendance> l = _kids_AttendanceDal.getAll();
            List<Kids_AttendanceDTO> lDTO = imapper.Map<List<KidsAttendance>, List<Kids_AttendanceDTO>>(l);
            return lDTO;
        }

        public bool uppdate(Kids_AttendanceDTO kids_Attendance)
        {
            KidsAttendance KidsAttendanceDal = imapper.Map<Kids_AttendanceDTO, KidsAttendance>(kids_Attendance);
            bool b = _kids_AttendanceDal.uppdate(KidsAttendanceDal);

            return b;
        }

        public object Delete(int attendanceId)
        {
            bool b = _kids_AttendanceDal.Delete(attendanceId);

            return b;
        }

        public bool AddKids_Attendance(Kids_AttendanceDTO kids_Attendance)
        {
            KidsAttendance KidsAttendanceDal = imapper.Map<Kids_AttendanceDTO, KidsAttendance>(kids_Attendance);
            bool b = _kids_AttendanceDal.AddKids_Attendance(KidsAttendanceDal);

            return b;
        }

    }
}
