using AutoMapper;
using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class TypeClassBL
    {
        IMapper imapper;
        TypeClassDAL _type_ClassDAL = new TypeClassDAL();

        public TypeClassBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            });
            imapper = config.CreateMapper();
        }

        public List<TypeClassDTO> getAll()
        {
            List<TypeClass> l = _type_ClassDAL.getAll();
            List<TypeClassDTO> lDTO = imapper.Map<List<TypeClass>, List<TypeClassDTO>>(l);
            return lDTO;
        }

        public object update(TypeClassDTO type_Class)
        {
            TypeClass typeClassDal = imapper.Map<TypeClassDTO, TypeClass>(type_Class);
            bool b = _type_ClassDAL.update(typeClassDal);

            return b;
        }

        public object AddTypeClass(TypeClassDTO type_Class)
        {
            TypeClass typeClassDal = imapper.Map<TypeClassDTO, TypeClass>(type_Class);
            bool b = _type_ClassDAL.AddTypeClass(typeClassDal);

            return b;
        }

        public object Delete(int idTypeClass)
        {
            bool b = _type_ClassDAL.Delete(idTypeClass);

            return b;
        }
    }
}
