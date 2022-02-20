using AutoMapper;
using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
   public class Day_CareBL
    {

        IMapper imapper;
        Day_CareDAL _day_CareDal = new Day_CareDAL();

        public Day_CareBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            });
            imapper = config.CreateMapper();
        }

        public List<Day_CareDTO> getAll()
        {
            List<DayCare> l = _day_CareDal.getAll();
            List<Day_CareDTO> lDTO = imapper.Map<List<DayCare>, List<Day_CareDTO>>(l);
            return lDTO;
        }

        public bool uppdate(Day_CareDTO day_Care)
        {
            DayCare dayCareDal = imapper.Map<Day_CareDTO, DayCare>(day_Care);
            bool b = _day_CareDal.uppdate(dayCareDal);

            return b;
        }

        public bool AddDay_Care(Day_CareDTO day_Care)
        {
            DayCare DayCareDal = imapper.Map<Day_CareDTO, DayCare>(day_Care);
            bool b = _day_CareDal.AddDay_Care(DayCareDal);

            return b;
        }

        public object Delete(int idDayCare)
        {
            bool b = _day_CareDal.Delete(idDayCare);

            return b;
            
        }
    }
}
