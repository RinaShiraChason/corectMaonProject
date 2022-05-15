using AutoMapper;
using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class UserBL
    {

        IMapper imapper;
        UserDAL _UserDAL = new UserDAL();

        public UserBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            });
            imapper = config.CreateMapper();
        }

        public List<UserDTO> GetAll()
        {
            List<User> l = _UserDAL.GetAll();
            List<UserDTO> lDTO = imapper.Map<List<User>, List<UserDTO>>(l);
            return lDTO;
        }
        public List<UserDTO> GetParents()
        {
            List<User> l = _UserDAL.GetParents();
            List<UserDTO> lDTO = imapper.Map<List<User>, List<UserDTO>>(l);
            return lDTO;
        }
        public List<UserDTO> GetTeachers()
        {
            List<User> l = _UserDAL.GetTeachers();
            List<UserDTO> lDTO = imapper.Map<List<User>, List<UserDTO>>(l);
            return lDTO;
        }
        public List<UserDTO> GetTeachersAndManagers()
        {
            List<User> l = _UserDAL.GetTeachersAndManagers();
            List<UserDTO> lDTO = imapper.Map<List<User>, List<UserDTO>>(l);
            return lDTO;
        }
        
        public bool update(UserDTO person)
        {
            User UserDAL = imapper.Map<UserDTO, User>(person);
            bool b = _UserDAL.update(UserDAL);

            return b;
        }

        public int AddUser(UserDTO person)
        {
            User UserDAL = imapper.Map<UserDTO, User>(person);
            int prsonId = _UserDAL.AddUser(UserDAL);

            return prsonId;
        }
        public int AddUpdateUser(UserDTO person)
        {
            User UserDAL = imapper.Map<UserDTO, User>(person);
            int prsonId = _UserDAL.AddUpdateUser(UserDAL);

            return prsonId;
        }
        
        public UserDTO Login(UserDTO userD)
        {
            var u = _UserDAL.Login(userD.Email, userD.Password);
            var user = imapper.Map<User, UserDTO>(u);
            return user;

        }



        public object Delete(int personTz)
        {
            bool b = _UserDAL.Delete(personTz);

            return b;
        }
    }
}
