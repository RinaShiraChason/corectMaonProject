using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Type_EmployeeDAL
    {
        newMaonContext DB = new newMaonContext();

        public List<TypeEmployee> getAll()
        {
            return DB.TypeEmployees.ToList();
        }

        public bool uppdate(TypeEmployee typeEmployeeDal)
        {
            TypeEmployee k = DB.TypeEmployees.FirstOrDefault(x => x.IdTypeEmp == typeEmployeeDal.IdTypeEmp);
            if (k != null)
            {

                k.IdTypeEmp = typeEmployeeDal.IdTypeEmp;
                k.TypeEmpName = typeEmployeeDal.TypeEmpName;
                k.TeacherId = typeEmployeeDal.TeacherId;


                try
                {
                    DB.SaveChanges();
                }
                catch
                {
                    return false;
                }


            }
            return true;

        }

        public bool AddType_Employee(TypeEmployee typeEmployeeDal)
        {
            DB.TypeEmployees.Add(typeEmployeeDal);

            try
            {
                DB.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Delete(int idTypeEmp)
        {
            TypeEmployee k = DB.TypeEmployees.FirstOrDefault(x => x.IdTypeEmp == idTypeEmp);

            DB.TypeEmployees.Remove(k);
            try
            {
                DB.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
