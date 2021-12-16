﻿using AutoMapper;
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

        public List<KidsDTO> getAll()
        {
          List<Kid> l=  _kidsDal.getAll();
          List<KidsDTO> lDTO = imapper.Map<List<Kid>, List<KidsDTO>>(l);
          return lDTO;
        }

        public bool uppdate(KidsDTO kids)
        {
            Kid kidDal = imapper.Map<KidsDTO, Kid>(kids);
            bool b = _kidsDal.uppdate(kidDal);

            return b;
        }

        public bool AddKids(KidsDTO kids)
        {
            Kid kidDal = imapper.Map<KidsDTO, Kid>(kids);
            bool b = _kidsDal.AddKids(kidDal);

            return b;
        }
    }
}
