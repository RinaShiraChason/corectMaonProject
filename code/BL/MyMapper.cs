using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class MyMapper : AutoMapper.Profile
    {
        public MyMapper()
        {
            CreateMap<Kid, KidsDTO>();
            CreateMap<KidsDTO, Kid>();

            CreateMap<KidsAttendance, Kids_AttendanceDTO>();
            CreateMap<Kids_AttendanceDTO, KidsAttendance>();



        }

    }
}
