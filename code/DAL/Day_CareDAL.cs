using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Day_CareDAL
    {
        newMaonContext DB = new newMaonContext();

        public List<DayCare> getAll()
        {
            return DB.DayCares.ToList();
        }

        public bool uppdate(DayCare dayCareDal)
        {
            DayCare k = DB.DayCares.FirstOrDefault(x => x.IdDayCare == dayCareDal.IdDayCare);
            if (k != null)
            {
                k.IdDayCare = dayCareDal.IdDayCare;
                k.NameDayCare = dayCareDal.NameDayCare;
                k.NumClasses = dayCareDal.NumClasses;
                k.DressDayCare = dayCareDal.DressDayCare;
                k.AboutDayCare = dayCareDal.AboutDayCare;
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

        public bool AddDay_Care(DayCare DayCareDal)
        {
            DB.DayCares.Add(DayCareDal);

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

        public bool Delete(int idDayCare)
        {
            DayCare k = DB.DayCares.FirstOrDefault(x => x.IdDayCare == idDayCare);

            DB.DayCares.Remove(k);
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
