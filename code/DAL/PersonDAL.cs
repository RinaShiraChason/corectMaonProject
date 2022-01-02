using DAL.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public class PersonDAL
    {

        newMaonContext DB = new newMaonContext();
        
        public List<Person> getAll()
        {
            return DB.Person.ToList();
        }

        public bool uppdate(Person PersonDAL)
        {
            Person p = DB.Person.FirstOrDefault(x => x.PersonTz == PersonDAL.PersonTz);
            if (p != null)
            {
                p.PersonName = PersonDAL.PersonName;
                p.Adress = PersonDAL.Adress;
                p.Email = PersonDAL.Email;
                p.PhoneNamber1 = PersonDAL.PhoneNamber1;
                p.PhoneNamber2 = PersonDAL.PhoneNamber2;

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

        public bool AddPerson(Person PersonDAL)
        {
            DB.Person.Add(PersonDAL);

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
