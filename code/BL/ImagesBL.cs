using AutoMapper;
using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class ImagesBL
    {
        IMapper imapper;
         ImagesDAL imagesDAL = new ImagesDAL();
        public ImagesBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            });
            imapper = config.CreateMapper();
        }
        public List<Images> GetAll()
        {

            List<Images> l = imagesDAL.GetAll();

            return l;
        }
        public List<Images> GetAllByClassId(int classId)
        {

            List<Images> l = imagesDAL.GetAllByClassId(classId);

            return l;
        }
        public ImagesDTO GetById(int classId)
        {

            var lI = imagesDAL.GetById(classId);
            var tModel = imapper.Map<Images, ImagesDTO>(lI);
            return tModel;
        }
        
        public object update(ImagesDTO image)
        {
      
            Images tModel = imapper.Map<ImagesDTO, Images>(image);

            imagesDAL.update(tModel);
            return true;
        }

        public bool UploadImage(int id, string image)
        {
            bool b = imagesDAL.UploadImage(id, image);

            return b;
        }


        public object Delete(int id)
        {
            bool b = imagesDAL.Delete(id);

            return b;
        }

        public bool AddImages(ImagesDTO images)
        {

            Images tModel = imapper.Map<ImagesDTO, Images>(images);
            imagesDAL.AddImages(tModel);
            return true;

        }
        public int AddUpdateImage(ImagesDTO images)
        {

            Images tModel = imapper.Map<ImagesDTO, Images>(images);
            var id = imagesDAL.AddUpdateImage(tModel);
            return id;

        }
        

    }
}
