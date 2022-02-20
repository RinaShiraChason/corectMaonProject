using AutoMapper;
using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class Type_EmployeeBL
    {
        IMapper imapper;
        Type_EmployeeDAL _type_EmployeeDAL = new Type_EmployeeDAL();

        public Type_EmployeeBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            });
            imapper = config.CreateMapper();
        }
        public List<Type_EmployeeDTO> getAll()
        {
            List<TypeEmployee> l = _type_EmployeeDAL.getAll();
            List<Type_EmployeeDTO> lDTO = imapper.Map<List<TypeEmployee>, List<Type_EmployeeDTO>>(l);
            return lDTO;
        }

        public object Delete(int idTypeEmp)
        {
            bool b = _type_EmployeeDAL.Delete(idTypeEmp);

            return b;
        }

        public object AddType_Employee(Type_EmployeeDTO type_Employee)
        {
            TypeEmployee typeEmployeeDal = imapper.Map<Type_EmployeeDTO, TypeEmployee>(type_Employee);
            bool b = _type_EmployeeDAL.AddType_Employee(typeEmployeeDal);

            return b;
        }

        public object uppdate(Type_EmployeeDTO type_Employee)
        {
            TypeEmployee typeEmployeeDal = imapper.Map<Type_EmployeeDTO, TypeEmployee>(type_Employee);
            bool b = _type_EmployeeDAL.uppdate(typeEmployeeDal);

            return b;
        }
    }
}
