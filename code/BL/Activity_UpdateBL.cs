using AutoMapper;
using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class Activity_UpdateBL
    {

        IMapper imapper;
        Activity_UpdateDAL _activity_UpdateDal = new Activity_UpdateDAL();
        
        public Activity_UpdateBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            });
            imapper = config.CreateMapper();
        }

        public List<Activity_UpdateDTO> getAll()
        {
            List<ActivityUpdate> l = _activity_UpdateDal.getAll();
            List<Activity_UpdateDTO> lDTO = imapper.Map<List<ActivityUpdate>, List<Activity_UpdateDTO>>(l);
            return lDTO;
        }

        public bool uppdate(Activity_UpdateDTO Activity_Update)
        {
            ActivityUpdate ActivityUpdateDal = imapper.Map<Activity_UpdateDTO, ActivityUpdate>(Activity_Update);
            bool b = _activity_UpdateDal.uppdate(ActivityUpdateDal);

            return b;
        }

        public object AddActivity_Update(Activity_UpdateDTO activity_Update)
        {
            ActivityUpdate activityUpdateDal = imapper.Map<Activity_UpdateDTO, ActivityUpdate>(activity_Update);
            bool b = _activity_UpdateDal.AddActivity_Update(activityUpdateDal);

            return b;
        }

        public object Delete(int idActivityUpdate)
        {
            bool b = _activity_UpdateDal.Delete(idActivityUpdate);

            return b;
        }

        public bool AddKids(Activity_UpdateDTO Activity_Update)
        {
            ActivityUpdate ActivityUpdateDal = imapper.Map<Activity_UpdateDTO, ActivityUpdate>(Activity_Update);
            bool b = _activity_UpdateDal.AddActivity_Update(ActivityUpdateDal);

            return b;
        }
    }
}
