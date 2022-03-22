using DAL.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ImagesDAL
    {


        public List<Images> GetAll()
        {
            using (var db = new newMaonContext())
            {
                List<Images> lImagess = db.Images.OrderByDescending(z=>z.ImageDate).ToList();
                return lImagess;
            }
        }
        public List<Images> GetAllByClassId(int classId)
        {
            using (var db = new newMaonContext())
            {
                List<Images> lImagess = db.Images.Include("UserTeacher").Where(x => x.ClassId == classId).OrderByDescending(z => z.ImageDate).ToList();
                return lImagess;
            }
        }
        public bool update(Images imagesDal)
        {
            using (var db = new newMaonContext())
            {
                Images prt = db.Images.FirstOrDefault(x => x.ImageId == imagesDal.ImageId);
                if (prt != null)
                {
                    prt.ImageData = imagesDal.ImageData;
                    prt.ImageDate = imagesDal.ImageDate;
                    prt.ImageTitle = imagesDal.ImageTitle;
                    prt.ImageURL = imagesDal.ImageURL;
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

        public void AddImagess(Images tModel)
        {
            using (var db = new newMaonContext())
            {
                try
                {
                    db.Images.Add(tModel);
                    db.SaveChanges();
                }
                catch
                {



                }
            }
        }

        public bool Delete(int imagesId)
        {
            using (var db = new newMaonContext())
            {
                Images k = db.Images.FirstOrDefault(x => x.ImageId == imagesId);
                try
                {
                    db.Images.Remove(k);
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

