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


            CreateMap<ActivityUpdate, ActivityUpdateDTO>();
            CreateMap<ActivityUpdateDTO, ActivityUpdate>();


            CreateMap<Class, ClassesDTO>();
            CreateMap<ClassesDTO, Class>();


            CreateMap<DayCare, DayCareDTO>();
            CreateMap<DayCareDTO, DayCare>();


            CreateMap<KidsAttendance, KidsAttendanceDTO>();
            CreateMap<KidsAttendanceDTO, KidsAttendance>();


            CreateMap<Kid, KidsDTO>();
            CreateMap<KidsDTO, Kid>();

            CreateMap<Images, ImagesDTO>();
            CreateMap<ImagesDTO, Images>();

            CreateMap<ExternalData, ExternalDataDTO>();
            CreateMap<ExternalDataDTO, ExternalData>();

            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();


            CreateMap<PlacementOfATeacher, PlacementOfATeacherDTO>();
            CreateMap<PlacementOfATeacherDTO, PlacementOfATeacher>();

            CreateMap<Messages, MessagesDTO>();
            CreateMap<MessagesDTO, Messages>();

            CreateMap<TypeClass, TypeClassDTO>();
            CreateMap<TypeClassDTO, TypeClass>();


            CreateMap<RecoverLosts, RecoverLostsDTO>();
            CreateMap<RecoverLostsDTO, RecoverLosts>();


        }

    }
}
