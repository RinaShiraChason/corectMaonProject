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


            CreateMap<ActivityUpdate, Activity_UpdateDTO>();
            CreateMap<Activity_UpdateDTO, ActivityUpdate>();


            CreateMap<Class, ClassesDTO>();
            CreateMap<ClassesDTO, Class>();


            CreateMap<DayCare, Day_CareDTO>();
            CreateMap<Day_CareDTO, DayCare>();


            CreateMap<KidsAttendance, Kids_AttendanceDTO>();
            CreateMap<Kids_AttendanceDTO, KidsAttendance>();


            CreateMap<Kid, KidsDTO>();
            CreateMap<KidsDTO, Kid>();

            CreateMap<Parent, ParentsDTO>();
            CreateMap<ParentsDTO, Parent>();


            CreateMap<Person, PersonDTO>();
            CreateMap<PersonDTO, Person>();


            CreateMap<PlacementOfATeacher, Placement_Of_A_TeacherDTO>();
            CreateMap<PlacementOfATeacher, PlacementOfATeacher>();

            CreateMap<TeacherAndManager, TeacherAndManagerDTO>();
            CreateMap<TeacherAndManagerDTO, TeacherAndManager>();

            CreateMap<TypeClass, Type_ClassDTO>();
            CreateMap<Type_ClassDTO, TypeClass>();


            CreateMap<TypeEmployee, Type_EmployeeDTO>();
            CreateMap<Type_EmployeeDTO, TypeEmployee>();


        }

    }
}
