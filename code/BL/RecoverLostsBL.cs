using AutoMapper;
using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class RecoverLostsBL
    {
        IMapper imapper;
        RecoverLostsDAL _RecoverLostDAL = new RecoverLostsDAL();

        public RecoverLostsBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            });
            imapper = config.CreateMapper();
        }
        public List<RecoverLostsDTO> GetAll()
        {
            List<RecoverLosts> l = _RecoverLostDAL.GetAll();
            List<RecoverLostsDTO> lDTO = imapper.Map<List<RecoverLosts>, List<RecoverLostsDTO>>(l);
            return lDTO;
        }
        public RecoverLostsDTO GetById(int id)
        {
            RecoverLosts l = _RecoverLostDAL.GetById(id);
            RecoverLostsDTO sDTO = imapper.Map<RecoverLosts, RecoverLostsDTO>(l);
            return sDTO;
        }
        
        public object Delete(int idRecoverLost)
        {
            bool b = _RecoverLostDAL.Delete(idRecoverLost);

            return b;
        }

        public object AddRecoverLosts(RecoverLostsDTO recoverLost)
        {
            RecoverLosts rec = imapper.Map<RecoverLostsDTO, RecoverLosts>(recoverLost);

            int b = _RecoverLostDAL.AddRecoverLostsId(rec);

            return b;
        }

        public object AddUpdateRecoverLost(RecoverLostsDTO recoverLosts)
        {
            RecoverLosts rec = imapper.Map<RecoverLostsDTO, RecoverLosts>(recoverLosts);

            int b = 0;
            if (rec.RecoverLostsId == 0)
            {
                b = _RecoverLostDAL.AddRecoverLostsId(rec);
            }
            else
            {
                b = _RecoverLostDAL.update(rec);
            }



            return b;
        }

        public bool UploadImage(int id, string image)
        {
            bool b = _RecoverLostDAL.UploadImage(id, image);

            return b;
        }
        public object update(RecoverLostsDTO recoverLost)
        {
            RecoverLosts rec = imapper.Map<RecoverLostsDTO, RecoverLosts>(recoverLost);
            int b = _RecoverLostDAL.update(rec);

            return b;
        }
    }
}
