using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
   public class ImagesDAL
    {
        newMaonContext DB = new newMaonContext();

        public List<Images> getAll()
        {
            List<Images> lImagess = DB.Images.ToList();
        
         

            return lImagess;
        }

        public bool update(Images imagesDal)
        {
            Images prt = DB.Images.FirstOrDefault(x => x.ImageId == imagesDal.ImageId);
            if (prt != null)
            {
                prt.ImageData = imagesDal.ImageData;
                prt.ImageDate = imagesDal.ImageDate;
                prt.ImageTitle = imagesDal.ImageTitle;
                prt.ImageURL = imagesDal.ImageURL;
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

        public void AddImagess(Images tModel)
        {
            try
            {
                DB.Images.Add(tModel);
                DB.SaveChanges();
            }
            catch
            {
            


            }
        }

        public bool Delete(int imagesId)
        {
            Images k = DB.Images.FirstOrDefault(x => x.ImageId == imagesId);
             try
            {
                DB.Images.Remove(k);
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

