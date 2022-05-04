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

        public void AddUpdateMessage(Messages tModel)
        {
            using (var db = new newMaonContext())
            {
                Messages k = db.Messages.FirstOrDefault(x => x.MessageId == tModel.MessageId);
                if (k != null)
                {

                    k.MessageDateTime = tModel.MessageDateTime;
                    k.MessageContent = tModel.MessageContent;
                    k.UserToId = tModel.UserToId;
                    k.UserFromId = tModel.UserFromId;
                    k.KidId = tModel.KidId;
                }
                else
                {
                    db.Messages.Add(tModel);
                }
                try
                {
                    db.SaveChanges();
                }
                catch
                {

                }


            }
        }

        public void AddMessages(Messages tModel)
        {
            using (var db = new newMaonContext())
            {
                try
                {
                    db.Messages.Add(tModel);
                    db.SaveChanges();
                }
                catch
                {

                }

            }
        }

        public List<Messages> GetAll()
        {
            using (var db = new newMaonContext())
            {
                List<Messages> lData = db.Messages.ToList();

                return lData;
            }
        }

        public bool Delete(int id)
        {
            using (var db = new newMaonContext())
            {
                Messages t = db.Messages.FirstOrDefault(x => x.MessageId == id);
                try
                {
                    db.Messages.Remove(t);
                    db.SaveChanges();


                }
                catch
                {
                    return false;
                }
                return true;
            }
        }


        public List<Messages> GetMessagesByTo(int userToId)
        {
            using (var db = new newMaonContext())
            {
                List<Messages> lData = db.Messages.Include("UserFrom").Include("UserTo").Include("Kid").Where(x => x.UserToId == userToId).OrderBy(x => x.MessageDateTime).ToList();
                return lData;
            }
        }

        public List<Messages> GetMessagesByFrom(int userFromId)
        {
            using (var db = new newMaonContext())
            {
                List<Messages> lData = db.Messages.Include("UserFrom").Include("UserTo").Include("Kid").Where(x => x.UserFromId == userFromId).OrderBy(x => x.MessageDateTime).ToList();
                return lData;
            }
        }

        public List<Messages> getAllByTeacherId(int teacherId)
        {
            using (var db2 = new newMaonContext())
            {
                var userToID = db2.Users.FirstOrDefault(x => x.UserId == teacherId).ClassId;
                var messages = db2.Messages.Include("Class").Include("UserParent").Where(x => x.UserToId == userToID).ToList();

                return messages;

            }
        }

        //public Messages getByTZAndPass(long tz, string pass)
        //{
        //    Messages Teacher = db.Messages.FirstOrDefault(x => x.TeacherTz == tz && x.UserTzNavigation.Password == pass);
        //    User User = db.Users.FirstOrDefault(x => x.UserTz == Teacher.UserTz);

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
            using (var db = new newMaonContext())
            {
                Messages k = db.Messages.FirstOrDefault(x => x.MessageId == tModel.MessageId);
                if (k != null)
                {

                    k.MessageDateTime = tModel.MessageDateTime;
                    k.MessageContent = tModel.MessageContent;
                    k.UserToId = tModel.UserToId;
                    k.UserFromId = tModel.UserFromId;
                    k.KidId = tModel.KidId;

                    try
                    {
                        db.SaveChanges();
                    }
                    catch
                    {

                    }
                }
            }
        }
    }
}