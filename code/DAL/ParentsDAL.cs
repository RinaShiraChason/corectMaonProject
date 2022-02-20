using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
   public class ParentsDAL
    {
        newMaonContext DB = new newMaonContext();

        public List<ParentsAndPeson> getAll()
        {
            List<Parent> lParents = DB.Parent.ToList();
            List<Person> lPerson = DB.People.ToList();

            List<ParentsAndPeson> LParentsAndPeople = new List<ParentsAndPeson>();
            ParentsAndPeson parentsAndPerson = new ParentsAndPeson();

            var newObject = (from parents in lParents
                             join person in lPerson
                             on parents.PersonTz equals person.PersonTz
                             select new
                             {
                                 ParentsId = parents.ParentsId,
                                 ParentsTz = parents.ParentsTz,
                                 PersonName = person.PersonName,
                                 Adress = person.Adress,
                                 Email = person.Email,
                                 PhoneNamber1 = person.PhoneNamber1,
                                 PhoneNamber2 = person.PhoneNamber2,
                                 Password = person.Password
                             }).ToList();

            foreach (var item in newObject)
            {
                parentsAndPerson.ParentsId = item.ParentsId;
                parentsAndPerson.PersonName = item.PersonName;
                parentsAndPerson.ParentsTz = item.ParentsTz;
                parentsAndPerson.Adress = item.Adress;
                parentsAndPerson.Email = item.Email;
                parentsAndPerson.PhoneNamber1 = item.PhoneNamber1;
                parentsAndPerson.PhoneNamber2 = item.PhoneNamber2;
                parentsAndPerson.Password = item.Password;
                LParentsAndPeople.Add(parentsAndPerson);
                parentsAndPerson = new ParentsAndPeson();

            }

            return LParentsAndPeople;
        }

        public bool uppdate(Parent parentsDal)
        {
            Parent prt = DB.Parent.FirstOrDefault(x => x.ParentsId == parentsDal.ParentsId);
            if (prt != null)
            {
                prt.ParentsTz = parentsDal.ParentsTz;
                prt.PersonTz = parentsDal.PersonTz;
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

        public void AddParents(Parent tModel)
        {
            try
            {
                DB.Parent.Add(tModel);
                DB.SaveChanges();
            }
            catch
            {
                Person p = DB.People.FirstOrDefault(x => x.PersonTz == tModel.PersonTz);
                if (p != null)
                {
                    DB.Remove(p);
                    DB.SaveChanges();

                }


            }
        }

        public bool Delete(int parentsId)
        {
            Parent k = DB.Parent.FirstOrDefault(x => x.ParentsId == parentsId);
            Person person = DB.People.FirstOrDefault(x => x.PersonTz == k.PersonTz);
            try
            {
                DB.Parent.Remove(k);
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

        public ParentsAndPeson getByTZAndPass(long tz, string pass)
        {
            Parent Parent = DB.Parent.FirstOrDefault(x => x.ParentsTz == tz && x.PersonTzNavigation.Password == pass);
            Person Person = DB.People.FirstOrDefault(x => x.PersonTz == Parent.PersonTz);

            ParentsAndPeson parentsAndPeson = new ParentsAndPeson();

            parentsAndPeson.ParentsId = Parent.ParentsId;
            parentsAndPeson.PersonName = Person.PersonName;
            parentsAndPeson.ParentsTz = Parent.ParentsTz;
            parentsAndPeson.Adress = Person.Adress;
            parentsAndPeson.Email = Person.Email;
            parentsAndPeson.PhoneNamber1 = Person.PhoneNamber1;
            parentsAndPeson.PhoneNamber2 = Person.PhoneNamber2;
            parentsAndPeson.Password = Person.Password;

            return parentsAndPeson;
        }
    }
    }

