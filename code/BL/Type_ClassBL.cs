using AutoMapper;
using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class Type_ClassBL
    {
        IMapper imapper;
        Type_ClassDAL _type_ClassDAL = new Type_ClassDAL();

        public Type_ClassBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            });
            imapper = config.CreateMapper();
        }

        public List<Type_ClassDTO> getAll()
        {
            List<TypeClass> l = _type_ClassDAL.getAll();
            List<Type_ClassDTO> lDTO = imapper.Map<List<TypeClass>, List<Type_ClassDTO>>(l);
            return lDTO;
        }

        public object uppdate(Type_ClassDTO type_Class)
        {
            TypeClass typeClassDal = imapper.Map<Type_ClassDTO, TypeClass>(type_Class);
            bool b = _type_ClassDAL.uppdate(typeClassDal);

            return b;
        }

        public object AddType_Class(Type_ClassDTO type_Class)
        {
            TypeClass typeClassDal = imapper.Map<Type_ClassDTO, TypeClass>(type_Class);
            bool b = _type_ClassDAL.AddType_Class(typeClassDal);

            return b;
        }

        public object Delete(int idTypeClass)
        {
            bool b = _type_ClassDAL.Delete(idTypeClass);

            return b;
        }
    }
}
