using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
   public class UserDAL
    {

        newMaonContext DB = new newMaonContext();
        
        public List<User> getAll()
        {
            return DB.Users.ToList();
        }
        public User Login(string userTz, string pas)
        {
            return DB.Users.FirstOrDefault(x=>x.UserName == userTz && x.Password == pas);
        }
        
        public bool update(User UserDAL)
        {
            User p = DB.Users.FirstOrDefault(x => x.UserId == UserDAL.UserId);
            if (p != null)
            {
                p.UserName = UserDAL.UserName;
                p.Address = UserDAL.Address;
                p.Email = UserDAL.Email;
                p.PhoneNamber1 = UserDAL.PhoneNamber1;
                p.PhoneNamber2 = UserDAL.PhoneNamber2;
                p.UserTz = UserDAL.UserTz;
                try
                {
                    DB.SaveChanges();
                }
                catch
                {
                    return false;
                }


            }
            return true;

        }

        public int AddUser(User UserDAL)
        {
            DB.Users.Add(UserDAL);

            try
            {
                DB.SaveChanges();
                return UserDAL.UserId;
            }
            catch
            {
                return 0;
            }
        
        }

        public bool Delete(int UserId)
        {
            User k = DB.Users.FirstOrDefault(x => x.UserId == UserId);

            DB.Users.Remove(k);
            try
            {
                DB.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}


