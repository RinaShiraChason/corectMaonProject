using AutoMapper;
using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class ExternalDataBL
    {
        IMapper imapper;
         ExternalDataDAL externalDataDAL = new ExternalDataDAL();
        public ExternalDataBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            });
            imapper = config.CreateMapper();
        }
        public List<ExternalData> GetAll()
        {

            List<ExternalData> l = externalDataDAL.GetAll();

            return l;
        }
        public List<ExternalData> GetAllByClassID(int classId)
        {

            List<ExternalData> l = externalDataDAL.GetAllByClassID(classId);

            return l;
        }
        public object update(ExternalDataDTO externalData)
        {
      
            ExternalData tModel = imapper.Map<ExternalDataDTO, ExternalData>(externalData);

            externalDataDAL.update(tModel);
            return true;
        }

        public object Delete(int id)
        {
            bool b = externalDataDAL.Delete(id);

            return b;
        }
        

               public bool AddUpdateExtData(ExternalDataDTO externalData)
        {

            ExternalData tModel = imapper.Map<ExternalDataDTO, ExternalData>(externalData);
            externalDataDAL.AddUpdateExtData(tModel);
            return true;

        }
        public bool AddExternalData(ExternalDataDTO externalData)
        {

            ExternalData tModel = imapper.Map<ExternalDataDTO, ExternalData>(externalData);
            externalDataDAL.AddExternalDatas(tModel);
            return true;

        }

      
    }
}
