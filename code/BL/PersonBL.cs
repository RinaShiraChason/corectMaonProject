using AutoMapper;
using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class PersonBL
    {
        IMapper imapper;
        PersonDAL _PersonDAL = new PersonDAL();

        public PersonBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            });
            imapper = config.CreateMapper();
        }

        public List<PersonDTO> getAll()
        {
            List<Person> l = _PersonDAL.getAll();
            List<PersonDTO> lDTO = imapper.Map<List<Person>, List<PersonDTO>>(l);
            return lDTO;
        }

        public bool uppdate(PersonDTO person)
        {
            Person PersonDAL = imapper.Map<PersonDTO, Person>(person);
            bool b = _PersonDAL.uppdate(PersonDAL);

            return b;
        }

        public bool AddPerson(PersonDTO person)
        {
            Person PersonDAL = imapper.Map<PersonDTO, Person>(person);
            bool b = _PersonDAL.AddPerson(PersonDAL);

            return b;
        }
    }
}
