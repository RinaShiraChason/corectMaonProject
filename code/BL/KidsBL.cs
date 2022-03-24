using AutoMapper;
using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;

namespace BL
{
    public class KidsBL
    {
        IMapper imapper;
        KidsDAL _kidsDal = new KidsDAL();

        public KidsBL()
        {
            var config = new MapperConfiguration(cfg =>
              {
                  cfg.AddProfile<MyMapper>();
              });
            imapper = config.CreateMapper();
        }

        public List<KidsDTO> GetAll()
        {
          List<Kid> l=  _kidsDal.GetAll();
          List<KidsDTO> lDTO = imapper.Map<List<Kid>, List<KidsDTO>>(l);
          return lDTO;
        }
        

 public List<KidsDTO> GetKidsByClassID(int cId)
        {
            List<Kid> l = _kidsDal.GetKidsByClassID(cId);
            List<KidsDTO> lDTO = imapper.Map<List<Kid>, List<KidsDTO>>(l);
            return lDTO;
        }
        public List<KidsDTO> GetKidsByTeacher(int teacherId)
        {
            List<Kid> l = _kidsDal.GetAllByTeacherId(teacherId);
            List<KidsDTO> lDTO = imapper.Map<List<Kid>, List<KidsDTO>>(l);
            return lDTO;
        }
        
        public bool update(KidsDTO kids)
        {
            Kid kidDal = imapper.Map<KidsDTO, Kid>(kids);
            bool b = _kidsDal.update(kidDal);

            return b;
        }

        public object GetTodayKidsWithAttendenc(int classId)
        {
            List<Kid> l = _kidsDal.GetTodayKidsWithAttendenc(classId);
            List<KidsDTO> lDTO = imapper.Map<List<Kid>, List<KidsDTO>>(l);
            return lDTO;
        }
        public object GetTodayKidsWithDayCare(int classId)
        {
            List<Kid> l = _kidsDal.GetTodayKidsWithDayCare(classId);
            List<KidsDTO> lDTO = imapper.Map<List<Kid>, List<KidsDTO>>(l);
            return lDTO;
        }
        public object GetTodayKidsData(int classId)
        {
            List<Kid> l = _kidsDal.GetTodayKidsData(classId);
            List<KidsDTO> lDTO = imapper.Map<List<Kid>, List<KidsDTO>>(l);
            return lDTO;
        }
        public object GetHistoryKidsData(int kidId,int month,int year)
        {
            Kid l = _kidsDal.GetHistoryKidsData(kidId,month,year);
            KidsDTO lDTO = imapper.Map<Kid, KidsDTO>(l);
            return lDTO;
        }
        
        public bool AddKids(KidsDTO kids)
        {
            Kid kidDal = imapper.Map<KidsDTO, Kid>(kids);
            bool b = _kidsDal.AddKids(kidDal);

            return b;
        }
        public bool AddUpdateKid(KidsDTO kids)
        {
            Kid kidDal = imapper.Map<KidsDTO, Kid>(kids);
            bool b = _kidsDal.AddUpdateKid(kidDal);

            return b;
        }
        
        public bool Delete(long tz)
        {
            bool b = _kidsDal.Delete(tz);

            return b;
        }
    }
}
