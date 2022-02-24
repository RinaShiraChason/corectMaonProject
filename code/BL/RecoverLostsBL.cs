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
        public List<RecoverLostsDTO> getAll()
        {
            List<RecoverLosts> l = _RecoverLostDAL.getAll();
            List<RecoverLostsDTO> lDTO = imapper.Map<List<RecoverLosts>, List<RecoverLostsDTO>>(l);
            return lDTO;
        }

        public object Delete(int idRecoverLost)
        {
            bool b = _RecoverLostDAL.Delete(idRecoverLost);

            return b;
        }

        public object AddRecoverLosts(RecoverLostsDTO recoverLost)
        {
            RecoverLosts rec = imapper.Map<RecoverLostsDTO, RecoverLosts>(recoverLost);

            bool b = _RecoverLostDAL.AddRecoverLostsId(rec);

            return b;
        }

        public object update(RecoverLostsDTO recoverLost)
        {
            RecoverLosts rec = imapper.Map<RecoverLostsDTO, RecoverLosts>(recoverLost);
            bool b = _RecoverLostDAL.update(rec);

            return b;
        }
    }
}
