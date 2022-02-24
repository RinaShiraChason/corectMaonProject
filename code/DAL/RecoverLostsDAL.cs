using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class RecoverLostsDAL
    {
        newMaonContext DB = new newMaonContext();

        public List<RecoverLosts> getAll()
        {
            return DB.RecoverLosts.ToList();
        }

        public bool update(RecoverLosts typeRecoverLostsIdDal)
        {
            RecoverLosts k = DB.RecoverLosts.FirstOrDefault(x => x.RecoverLostsId == typeRecoverLostsIdDal.RecoverLostsId);
            if (k != null)
            {

                k.RecoverLostsDate = typeRecoverLostsIdDal.RecoverLostsDate;
                k.RecoverLostsInfo = typeRecoverLostsIdDal.RecoverLostsInfo;
                k.RecoverLostsImage = typeRecoverLostsIdDal.RecoverLostsImage;


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

        public bool AddRecoverLostsId(RecoverLosts typeRecoverLostsIdDal)
        {
            DB.RecoverLosts.Add(typeRecoverLostsIdDal);

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

        public bool Delete(int recoverLostsId)
        {
            RecoverLosts k = DB.RecoverLosts.FirstOrDefault(x => x.RecoverLostsId == recoverLostsId);

            DB.RecoverLosts.Remove(k);
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
