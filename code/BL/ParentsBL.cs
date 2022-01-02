using AutoMapper;
using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class ParentsBL
    {
        IMapper imapper;
        ParentsDAL _ParentsDAL = new ParentsDAL();

        public ParentsBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            });
            imapper = config.CreateMapper();
        }

        public List<ParentsDTO> getAll()
        {
            List<Parent> l = _ParentsDAL.getAll();
            List<ParentsDTO> lDTO = imapper.Map<List<Parent>, List<ParentsDTO>>(l);
            return lDTO;
        }

        public bool uppdate(ParentsDTO parents)
        {
            Parent ParentsDAL = imapper.Map<ParentsDTO, Parent>(parents);
            bool b = _ParentsDAL.uppdate(ParentsDAL);

            return b;
        }

        public bool AddParents(ParentsDTO parents)
        {
            Parent ParentsDAL = imapper.Map<ParentsDTO, Parent>(parents);
            bool b = _ParentsDAL.AddParents(ParentsDAL);

            return b;
        }

    }
}
