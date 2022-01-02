using AutoMapper;
using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class Placement_Of_A_TeacherBL
    {
        IMapper imapper;
        Placement_Of_A_TeacherDAL _Placement_Of_A_TeacherDAL = new Placement_Of_A_TeacherDAL();

        public Placement_Of_A_TeacherBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            });
            imapper = config.CreateMapper();
        }

        public List<Placement_Of_A_TeacherDTO> getAll()
        {
            List<PlacementOfATeacher> l = _Placement_Of_A_TeacherDAL.getAll();
            List<Placement_Of_A_TeacherDTO> lDTO = imapper.Map<List<PlacementOfATeacher>, List<Placement_Of_A_TeacherDTO>>(l);
            return lDTO;
        }

        public bool uppdate(Placement_Of_A_TeacherDTO pot)
        {
            PlacementOfATeacher Placement_Of_A_TeacherDAL = imapper.Map<Placement_Of_A_TeacherDTO, PlacementOfATeacher>(pot);
            bool b = _Placement_Of_A_TeacherDAL.uppdate(Placement_Of_A_TeacherDAL);

            return b;
        }

        public bool AddPlacementOfATeacher(Placement_Of_A_TeacherDTO pot)
        {
            PlacementOfATeacher Placement_Of_A_TeacherDAL = imapper.Map<Placement_Of_A_TeacherDTO, PlacementOfATeacher>(pot);
            bool b = _Placement_Of_A_TeacherDAL.AddPlacementOfATeacher(Placement_Of_A_TeacherDAL);

            return b;
        }
    }
}
