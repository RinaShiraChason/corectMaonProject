using AutoMapper;
using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class ClassesBL
    {

        IMapper imapper;
        ClassesDAL _classesDal = new ClassesDAL();

        public ClassesBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            });
            imapper = config.CreateMapper();
        }

        public List<ClassesDTO> GetAll()
        {
            List<Class> l = _classesDal.GetAll();
            List<ClassesDTO> lDTO = imapper.Map<List<Class>, List<ClassesDTO>>(l);
            return lDTO;
        }



        public bool update(ClassesDTO Classes)
        {
            Class ClassDal = imapper.Map<ClassesDTO, Class>(Classes);
            bool b = _classesDal.update(ClassDal);

            return b;
        }



        public bool AddClasses(ClassesDTO classes)
        {
            Class ClassDal = imapper.Map<ClassesDTO, Class>(classes);
            bool b = _classesDal.AddClasses(ClassDal);

            return b;
        }

        public object Delete(int classId)
        {
            bool b = _classesDal.Delete(classId);

            return b;
        }
    }
}
