using DAL.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DAL
{
    public class UserDAL
    {

        public List<User> GetAll()
        {
            using (var db = new newMaonContext())
            {
                return db.Users.ToList();
            }
        }
        public List<User> GetParents()
        {
            using (var db = new newMaonContext())
            {
                return db.Users.Include("Kids").Where(x => x.UserTypeId == 1).ToList();
            }
        }
        public List<User> GetTeachers()
        {
            using (var db = new newMaonContext())
            {
                return db.Users.Include("Class").Where(x => x.UserTypeId == 2).ToList();
            }
        }
        public List<User> GetTeachersAndManagers()
        {
            using (var db = new newMaonContext())
            {
                return db.Users.Include("Class").Where(x => x.UserTypeId == 2|| x.UserTypeId == 3).ToList();
            }
        }
        
        public User Login(string userTz, string pas)
        {
            using (var db = new newMaonContext())
            {
                return db.Users.Include("Kids").FirstOrDefault(x => (x.Email == userTz || x.UserName == userTz || x.UserTz == userTz) && x.Password == pas);
            }
        }

        public bool update(User UserDAL)
        {
            using (var db = new newMaonContext())
            {
                User p = db.Users.FirstOrDefault(x => x.UserId == UserDAL.UserId);
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
                        db.SaveChanges();
                    }
                    catch
                    {
                        return false;
                    }


                }
                return true;
            }
        }


        public int AddUpdateUser(User UserDAL)
        {
            using (var db = new newMaonContext())
            {
                User p = db.Users.FirstOrDefault(x => x.UserId == UserDAL.UserId);
                if (p != null)
                {
                    p.UserName = UserDAL.UserName;
                    p.Address = UserDAL.Address;
                    p.Email = UserDAL.Email;
                    p.PhoneNamber1 = UserDAL.PhoneNamber1;
                    p.PhoneNamber2 = UserDAL.PhoneNamber2;
                    p.UserTz = UserDAL.UserTz;
                    p.ClassId = UserDAL.ClassId;


                }
                else
                {
                    db.Users.Add(UserDAL);
                }

                try
                {
                    db.SaveChanges();
                    return UserDAL.UserId;
                }
                catch
                {
                    return 0;
                }

            }
        }


        public int AddUser(User UserDAL)
        {
            using (var db = new newMaonContext())
            {
                db.Users.Add(UserDAL);

                try
                {
                    db.SaveChanges();
                    return UserDAL.UserId;
                }
                catch
                {
                    return 0;
                }

            }
        }

        public bool Delete(int UserId)
        {
            using (var db = new newMaonContext())
            {
                User k = db.Users.FirstOrDefault(x => x.UserId == UserId);

                db.Users.Remove(k);
                try
                {
                    db.SaveChanges();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }
    }
}


