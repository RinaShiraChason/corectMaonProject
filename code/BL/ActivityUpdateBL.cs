using AutoMapper;
using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class ActivityUpdateBL
    {

        IMapper imapper;
        ActivityUpdateDAL _activity_UpdateDal = new ActivityUpdateDAL();
        
        public ActivityUpdateBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            });
            imapper = config.CreateMapper();
        }

        public List<ActivityUpdateDTO> GetAll()
        {
            List<ActivityUpdate> l = _activity_UpdateDal.GetAll();
            List<ActivityUpdateDTO> lDTO = imapper.Map<List<ActivityUpdate>, List<ActivityUpdateDTO>>(l);
            return lDTO;
        }
        public ActivityUpdateDTO GetTodayActivityUpdateByClass(int classId)
        {
            ActivityUpdate l = _activity_UpdateDal.GetTodayActivityUpdateByClass(classId);
            ActivityUpdateDTO lDTO = imapper.Map<ActivityUpdate, ActivityUpdateDTO>(l);
            return lDTO;
        }
        //
        public bool update(ActivityUpdateDTO ActivityUpdate)
        {
            ActivityUpdate ActivityUpdateDal = imapper.Map<ActivityUpdateDTO, ActivityUpdate>(ActivityUpdate);
            bool b = _activity_UpdateDal.update(ActivityUpdateDal);

            return b;
        }

        public object AddActivityUpdate(ActivityUpdateDTO activity_Update)
        {
            ActivityUpdate activityUpdateDal = imapper.Map<ActivityUpdateDTO, ActivityUpdate>(activity_Update);
            bool b = _activity_UpdateDal.AddActivityUpdate(activityUpdateDal);

            return b;
        }

        public object Delete(int idActivityUpdate)
        {
            bool b = _activity_UpdateDal.Delete(idActivityUpdate);

            return b;
        }

        public bool AddKids(ActivityUpdateDTO ActivityUpdate)
        {
            ActivityUpdate ActivityUpdateDal = imapper.Map<ActivityUpdateDTO, ActivityUpdate>(ActivityUpdate);
            bool b = _activity_UpdateDal.AddActivityUpdate(ActivityUpdateDal);

            return b;
        }
    }
}
