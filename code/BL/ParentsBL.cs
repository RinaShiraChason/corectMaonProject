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
        PersonBL personBL = new PersonBL();
        ParentsDAL _ParentsDAL = new ParentsDAL();

        public ParentsBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            });
            imapper = config.CreateMapper();
        }

        public List<ParentsAndPeson> getAll()
        {
            List<ParentsAndPeson> l = _ParentsDAL.getAll();

            return l;
        }

        public bool uppdate(ParentsDTO parents)
        {
            PersonDTO p = new PersonDTO();
            p = parents.myPerson;
            personBL.uppdate(p);


            Parent tModel = imapper.Map<ParentsDTO, Parent>(parents);

            _ParentsDAL.uppdate(tModel);
            return true;
        }

        public bool AddParents(ParentsDTO parents)
        {
            PersonDTO p = new PersonDTO();
            p = parents.myPerson;
            long personTz = personBL.AddPerson(p);

            parents.PersonTz = personTz;
            Parent tModel = imapper.Map<ParentsDTO, Parent>(parents);
          
            _ParentsDAL.AddParents(tModel);
            return true;
        }



        public object Delete(int parentsId)
        {
            bool b = _ParentsDAL.Delete(parentsId);

            return b;
        }

        public object getByTZAndPass(long tz, string pass)
        {
            ParentsAndPeson parentsAndPeson = _ParentsDAL.getByTZAndPass(tz, pass);
            return parentsAndPeson;
        }
    }
}
