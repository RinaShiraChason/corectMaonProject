using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DayCareDAL
    {
        newMaonContext DB = new newMaonContext();

        public List<DayCare> getAll()
        {
            return DB.DayCares.ToList();
        }

        public bool update(DayCare dayCareDal)
        {
            DayCare k = DB.DayCares.FirstOrDefault(x => x.IdDayCare == dayCareDal.IdDayCare);
            if (k != null)
            {
                k.IdDayCare = dayCareDal.IdDayCare;
                k.BehaviorDayCare = dayCareDal.BehaviorDayCare;
                k.FoodDayCare = dayCareDal.FoodDayCare;
                k.DressDayCare = dayCareDal.DressDayCare;
                k.CommentDayCare = dayCareDal.CommentDayCare;
                k.SleepDayCare = dayCareDal.SleepDayCare;
                k.DateCare = dayCareDal.DateCare;
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

        public bool AddDayCare(DayCare DayCareDal)
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
