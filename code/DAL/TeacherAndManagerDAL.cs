using DAL.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace DAL
{
    public class TeacherAndManagerDAL
    {
        newMaonContext DB = new newMaonContext();
        public void AddTeacherAndManager(TeacherAndManager tModel)
        {
            try
            {
                DB.TeacherAndManagers.Add(tModel);
                DB.SaveChanges();
            }
            catch
            {
                Person p = DB.People.FirstOrDefault(x => x.PersonTz == tModel.PersonTz);
                if(p!=null)
                {
                    DB.Remove(p);
                    DB.SaveChanges();

                }


            }

        }

        public List<TeacherAndPerson> getAll()
        {
            List<TeacherAndManager> lTeachers= DB.TeacherAndManagers.ToList();
            List<Person> lPerson = DB.People.ToList();

            List<TeacherAndPerson> LteacherAndPeople = new List<TeacherAndPerson>();
            TeacherAndPerson teacherAndPerson = new TeacherAndPerson();

            var newObject = (from teacher in lTeachers
                             join person in lPerson
                             on teacher.PersonTz equals person.PersonTz
                             select new
                             {
                                 TeacherId = teacher.TeacherId,
                                 TeacherTz = teacher.TeacherTz,
                                 PersonName = person.PersonName,
                                 Adress = person.Adress,
                                 Email = person.Email,
                                 PhoneNamber1 = person.PhoneNamber1,
                                 PhoneNamber2 = person.PhoneNamber2,
                                 Password=person.Password
                             }).ToList() ;

            foreach (var item in newObject)
            {
                teacherAndPerson.TeacherId = item.TeacherId;
                teacherAndPerson.PersonName = item.PersonName;
                teacherAndPerson.TeacherTz = item.TeacherTz;
                teacherAndPerson.Adress = item.Adress;
                teacherAndPerson.Email = item.Email;
                teacherAndPerson.PhoneNamber1 = item.PhoneNamber1;
                teacherAndPerson.PhoneNamber2 = item.PhoneNamber2;
                teacherAndPerson.Password = item.Password;
                LteacherAndPeople.Add(teacherAndPerson);
                teacherAndPerson = new TeacherAndPerson();

            }

            return LteacherAndPeople;
        }

        public bool Delete(long tz)
        {
            TeacherAndManager t = DB.TeacherAndManagers.FirstOrDefault(x => x.TeacherTz == tz);
            Person person = DB.People.FirstOrDefault(x => x.PersonTz == t.PersonTz);
            try
            {
                DB.TeacherAndManagers.Remove(t);
                DB.SaveChanges();
                DB.People.Remove(person);
                DB.SaveChanges();

            }
            catch
            {
                return false;
            }
            return true;
        }

        public TeacherAndPerson getByTZAndPass(long tz, string pass)
        {
            TeacherAndManager Teacher= DB.TeacherAndManagers.FirstOrDefault(x=>x.TeacherTz==tz && x.PersonTzNavigation.Password==pass );
            Person Person = DB.People.FirstOrDefault(x=>x.PersonTz==Teacher.PersonTz);

            TeacherAndPerson teacherAndPerson = new TeacherAndPerson();

                teacherAndPerson.TeacherId = Teacher.TeacherId;
                teacherAndPerson.PersonName = Person.PersonName;
                teacherAndPerson.TeacherTz = Teacher.TeacherTz;
                teacherAndPerson.Adress = Person.Adress;
                teacherAndPerson.Email = Person.Email;
                teacherAndPerson.PhoneNamber1 = Person.PhoneNamber1;
                teacherAndPerson.PhoneNamber2 = Person.PhoneNamber2;
                teacherAndPerson.Password = Person.Password;
 
            return teacherAndPerson;

        }

        public void uppdate(TeacherAndManager tModel)
        {
            TeacherAndManager k = DB.TeacherAndManagers.FirstOrDefault(x => x.TeacherId == tModel.TeacherId);
            if (k != null)
            {

                k.TeacherTz = tModel.TeacherTz;

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
