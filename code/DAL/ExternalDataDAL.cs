using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ExternalDataDAL
    {


        public List<ExternalData> GetAll()
        {
            using (var db = new newMaonContext())
            {
                List<ExternalData> lExternalDatas = db.ExternalData.ToList();
                return lExternalDatas;
            }
        }

        public bool update(ExternalData extDataDal)
        {
            using (var db = new newMaonContext())
            {
                ExternalData prt = db.ExternalData.FirstOrDefault(x => x.ExternalDataId == extDataDal.ExternalDataId);
                if (prt != null)
                {
                    prt.ExternalDataDate = extDataDal.ExternalDataDate;
                    prt.ExternalDataTitle = extDataDal.ExternalDataTitle;
                    prt.ExternalDataLink = extDataDal.ExternalDataLink;
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

        public void AddExternalDatas(ExternalData tModel)
        {
            using (var db = new newMaonContext())
            {
                try
                {
                    db.ExternalData.Add(tModel);
                    db.SaveChanges();
                }
                catch
                {


                }
            }
        }

        public bool Delete(int extDataId)
        {
            using (var db = new newMaonContext())
            {
                ExternalData k = db.ExternalData.FirstOrDefault(x => x.ExternalDataId == extDataId);
                try
                {
                    db.ExternalData.Remove(k);
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

