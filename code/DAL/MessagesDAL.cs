using DAL.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class MessagesDAL
    {
        newMaonContext DB = new newMaonContext();
        public void AddMessages(Messages tModel)
        {
            try
            {
                DB.Messages.Add(tModel);
                DB.SaveChanges();
            }
            catch
            {

            }

        }

        public List<Messages> getAll()
        {
            List<Messages> lData = DB.Messages.ToList();

            return lData;
        }

        public bool Delete(int id)
        {
            Messages t = DB.Messages.FirstOrDefault(x => x.MessageId == id);
            try
            {
                DB.Messages.Remove(t);
                DB.SaveChanges();
            

            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<Messages> getAllByTeacherId(int teacherId)
        {
            using (var db2 = new newMaonContext())
            {
                var userToID = db2.Users.FirstOrDefault(x => x.UserId == teacherId).ClassId;
                var messages = db2.Messages.Include("Class").Include("UserParent").Where(x => x.UserToId== userToID).ToList();

                return messages;

            }
        }

        //public Messages getByTZAndPass(long tz, string pass)
        //{
        //    Messages Teacher = DB.Messages.FirstOrDefault(x => x.TeacherTz == tz && x.UserTzNavigation.Password == pass);
        //    User User = DB.Users.FirstOrDefault(x => x.UserTz == Teacher.UserTz);

        //    Messages teacherAndUser = new Messages();

        //    teacherAndUser.TeacherId = Teacher.TeacherId;
        //    teacherAndUser.UserName = User.UserName;
        //    teacherAndUser.TeacherTz = Teacher.TeacherTz;
        //    teacherAndUser.Adress = User.Adress;
        //    teacherAndUser.Email = User.Email;
        //    teacherAndUser.PhoneNamber1 = User.PhoneNamber1;
        //    teacherAndUser.PhoneNamber2 = User.PhoneNamber2;
        //    teacherAndUser.Password = User.Password;

        //    return teacherAndUser;

        //}

        public void update(Messages tModel)
        {
            Messages k = DB.Messages.FirstOrDefault(x => x.MessageId == tModel.MessageId);
            if (k != null)
            {

                k.MessageDateTime = tModel.MessageDateTime;
                k.MessageContent = tModel.MessageContent;
                k.UserToId = tModel.UserToId;
                k.UserFromId = tModel.UserFromId;
                k.KidId = tModel.KidId;

                try
                {
                    DB.SaveChanges();
                }
                catch
                {

                }
            }
        }
    }
}
