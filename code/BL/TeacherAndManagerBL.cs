using AutoMapper;
using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class TeacherAndManagerBL
    {
        IMapper imapper;
        PersonBL personBL = new PersonBL();
        TeacherAndManagerDAL teacherAndManagerDAL = new TeacherAndManagerDAL();
        public TeacherAndManagerBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            });
            imapper = config.CreateMapper();
        }
        public List<TeacherAndPerson> getAll()
        {

            List<TeacherAndPerson> l = teacherAndManagerDAL.getAll();
           
            return l;
        }

        public object uppdate(TeacherAndManagerDTO teacherAndManager)
        {
            PersonDTO p = new PersonDTO();
            p = teacherAndManager.myPerson;
            personBL.uppdate(p);

           
            TeacherAndManager tModel = imapper.Map<TeacherAndManagerDTO, TeacherAndManager>(teacherAndManager);

            teacherAndManagerDAL.uppdate(tModel);
            return true;
        }

        public object Delete(long tz)
        {
            bool b = teacherAndManagerDAL.Delete(tz);

            return b;
        }

        public bool AddTeacherAndManager(TeacherAndManagerDTO teacherAndManager)
        {
            PersonDTO p= new PersonDTO();
            p = teacherAndManager.myPerson;
            long personTz=personBL.AddPerson(p);

            teacherAndManager.PersonTz = personTz;
            TeacherAndManager tModel = imapper.Map<TeacherAndManagerDTO, TeacherAndManager>(teacherAndManager);

            teacherAndManagerDAL.AddTeacherAndManager(tModel);
            return true;

        }

        public TeacherAndPerson getByTZAndPass(long tz, string pass)
        {
            TeacherAndPerson teacherAndPerson= teacherAndManagerDAL.getByTZAndPass(tz,pass);
            return teacherAndPerson;

        }
    }
}
