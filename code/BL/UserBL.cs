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

        public List<UserDTO> getAll()
        {
            List<User> l = _UserDAL.getAll();
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

        public UserDTO Login(UserDTO userD)
        {
            var u = _UserDAL.Login(userD.UserTz, userD.Password);
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
