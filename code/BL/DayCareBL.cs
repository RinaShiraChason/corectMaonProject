using AutoMapper;
using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
   public class DayCareBL
    {

        IMapper imapper;
        DayCareDAL _day_CareDal = new DayCareDAL();

        public DayCareBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            });
            imapper = config.CreateMapper();
        }

        public List<DayCareDTO> GetAll()
        {
            List<DayCare> l = _day_CareDal.GetAll();
            List<DayCareDTO> lDTO = imapper.Map<List<DayCare>, List<DayCareDTO>>(l);
            return lDTO;
        }

        public bool update(DayCareDTO day_Care)
        {
            DayCare dayCareDal = imapper.Map<DayCareDTO, DayCare>(day_Care);
            bool b = _day_CareDal.update(dayCareDal);

            return b;
        }

        public bool AddDayCare(DayCareDTO day_Care)
        {
            DayCare DayCareDal = imapper.Map<DayCareDTO, DayCare>(day_Care);
            bool b = _day_CareDal.AddDayCare(DayCareDal);

            return b;
        }

        public object Delete(int idDayCare)
        {
            bool b = _day_CareDal.Delete(idDayCare);

            return b;
            
        }
    }
}
