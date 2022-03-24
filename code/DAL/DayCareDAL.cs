using DAL.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DayCareDAL
    {


        public List<DayCare> GetAll()
        {
            using (var db = new newMaonContext())
            {
                return db.DayCares.ToList();
            }
        }
        public bool update(DayCare dayCareDal)
        {
            using (var db = new newMaonContext())
            {
                DayCare k = db.DayCares.FirstOrDefault(x => x.IdDayCare == dayCareDal.IdDayCare);
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
                        db.SaveChanges();
                    }
                    catch
                    {
                        return false;
                    }


                }
                return true;
            }
        }

        public DayCare GetDayCareByKids(int kidsId)
        {
            var today = DateTime.Today;
            using (var db = new newMaonContext())
            {
                var data = db.DayCares.Include("Kid").FirstOrDefault(x => x.KidId == kidsId && today == x.DateCare.Date);
                return data;
            }
        }


        public bool AddUpdateKidCare(DayCare dayCareDal)
        {
            using (var db = new newMaonContext())
            {
                DayCare k = db.DayCares.FirstOrDefault(x => x.IdDayCare == dayCareDal.IdDayCare);
                if (k != null)
                {
                    k.IdDayCare = dayCareDal.IdDayCare;
                    k.BehaviorDayCare = dayCareDal.BehaviorDayCare;
                    k.FoodDayCare = dayCareDal.FoodDayCare;
                    k.DressDayCare = dayCareDal.DressDayCare;
                    k.CommentDayCare = dayCareDal.CommentDayCare;
                    k.SleepDayCare = dayCareDal.SleepDayCare;
                    k.DateCare = dayCareDal.DateCare;
                }
                else
                {
                    db.DayCares.Add(dayCareDal);
                }


                try
                {
                    db.SaveChanges();
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
            using (var db = new newMaonContext())
            {
                db.DayCares.Add(DayCareDal);

                try
                {
                    db.SaveChanges();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }
        public bool Delete(int idDayCare)
        {
            using (var db = new newMaonContext())
            {
                DayCare k = db.DayCares.FirstOrDefault(x => x.IdDayCare == idDayCare);

                db.DayCares.Remove(k);
                try
                {
                    db.SaveChanges();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }
    }
}
