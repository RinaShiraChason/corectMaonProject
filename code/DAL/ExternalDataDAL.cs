using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
   public class ExternalDataDAL
    {
        newMaonContext DB = new newMaonContext();

        public List<ExternalData> getAll()
        { 
            List<ExternalData> lExternalDatas = DB.ExternalData.ToList();
        
         

            return lExternalDatas;
        }

        public bool update(ExternalData extDataDal)
        {
            ExternalData prt = DB.ExternalData.FirstOrDefault(x => x.ExternalDataId == extDataDal.ExternalDataId);
            if (prt != null)
            {
                prt.ExternalDataDate = extDataDal.ExternalDataDate;
                prt.ExternalDataTitle = extDataDal.ExternalDataTitle;
                prt.ExternalDataLink = extDataDal.ExternalDataLink;
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

        public void AddExternalDatas(ExternalData tModel)
        {
            try
            {
                DB.ExternalData.Add(tModel);
                DB.SaveChanges();
            }
            catch
            {
            


            }
        }

        public bool Delete(int extDataId)
        {
            ExternalData k = DB.ExternalData.FirstOrDefault(x => x.ExternalDataId == extDataId);
             try
            {
                DB.ExternalData.Remove(k);
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

