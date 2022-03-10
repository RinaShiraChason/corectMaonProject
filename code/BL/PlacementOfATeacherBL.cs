using AutoMapper;
using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class PlacementOfATeacherBL
    {
        IMapper imapper;
        PlacementOfATeacherDAL _Placement_Of_A_TeacherDAL = new PlacementOfATeacherDAL();

        public PlacementOfATeacherBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            });
            imapper = config.CreateMapper();
        }

        public List<PlacementOfATeacherDTO> GetAll()
        {
            List<PlacementOfATeacher> l = _Placement_Of_A_TeacherDAL.GetAll();
            List<PlacementOfATeacherDTO> lDTO = imapper.Map<List<PlacementOfATeacher>, List<PlacementOfATeacherDTO>>(l);
            return lDTO;
        }
        public PlacementOfATeacherDTO GetByTeacherId(int id)
        {
            PlacementOfATeacher l = _Placement_Of_A_TeacherDAL.GetByTeacherId(id);
            PlacementOfATeacherDTO lDTO = imapper.Map<PlacementOfATeacher, PlacementOfATeacherDTO>(l);
            return lDTO;
        }
        public bool update(PlacementOfATeacherDTO pot)
        {
            PlacementOfATeacher Placement_Of_A_TeacherDAL = imapper.Map<PlacementOfATeacherDTO, PlacementOfATeacher>(pot);
            bool b = _Placement_Of_A_TeacherDAL.update(Placement_Of_A_TeacherDAL);

            return b;
        }



        public bool AddPlacementOfATeacher(PlacementOfATeacherDTO pot)
        {
            PlacementOfATeacher Placement_Of_A_TeacherDAL = imapper.Map<PlacementOfATeacherDTO, PlacementOfATeacher>(pot);
            bool b = _Placement_Of_A_TeacherDAL.AddPlacementOfATeacher(Placement_Of_A_TeacherDAL);

            return b;
        }

        public object Delete(int idPlacementOfATeacher)
        {
            bool b = _Placement_Of_A_TeacherDAL.Delete(idPlacementOfATeacher);

            return b;
        }
    }
}
