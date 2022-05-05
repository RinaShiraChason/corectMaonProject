using DAL.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class RecoverLostsDAL
    {


        public List<RecoverLosts> GetAll()
        {
            using (var db = new newMaonContext())
            {
                var date = DateTime.Today.AddDays(-30);
                return db.RecoverLosts.Include("User").Where(x => x.RecoverLostsDate.Date >= date).OrderByDescending(x => x.RecoverLostsDate).ToList();
            }
        }
        public int update(RecoverLosts typeRecoverLostsIdDal)
        {
            using (var db = new newMaonContext())
            {
                RecoverLosts k = db.RecoverLosts.FirstOrDefault(x => x.RecoverLostsId == typeRecoverLostsIdDal.RecoverLostsId);
                if (k != null)
                {

                    // k.RecoverLostsDate = typeRecoverLostsIdDal.RecoverLostsDate;
                    k.RecoverLostsInfo = typeRecoverLostsIdDal.RecoverLostsInfo;
                    k.RecoverLostsImage = typeRecoverLostsIdDal.RecoverLostsImage;


                    try
                    {
                        db.SaveChanges();
                    }
                    catch
                    {
                        return typeRecoverLostsIdDal.RecoverLostsId; 
                    }


                }
                return typeRecoverLostsIdDal.RecoverLostsId;
            }
        }

        public RecoverLosts GetById(int id)
        {
            using (var db = new newMaonContext())
            {
                return db.RecoverLosts.FirstOrDefault(x=>x.RecoverLostsId == id);
            }
        }

        public int AddRecoverLostsId(RecoverLosts typeRecoverLostsIdDal)
        {
            using (var db = new newMaonContext())
            {
                db.RecoverLosts.Add(typeRecoverLostsIdDal);

                try
                {
                    db.SaveChanges();
                }
                catch
                {
                    return typeRecoverLostsIdDal.RecoverLostsId;
                }
                return typeRecoverLostsIdDal.RecoverLostsId;
            }
        }

        public bool UploadImage(int id, string image)
        {
            using (var db = new newMaonContext())
            {
                RecoverLosts k = db.RecoverLosts.FirstOrDefault(x => x.RecoverLostsId == id);
                if (k != null)
                {
                    k.RecoverLostsImage = image;

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

        public bool Delete(int recoverLostsId)
        {
            using (var db = new newMaonContext())
            {
                RecoverLosts k = db.RecoverLosts.FirstOrDefault(x => x.RecoverLostsId == recoverLostsId);

                db.RecoverLosts.Remove(k);
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
