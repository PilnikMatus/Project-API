using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class adminRepository
    {
        private MyContext context = new MyContext();

        public List<admin> FindAll()
        {
            return this.context.People.ToList();
        }

        public admin FindById(int id)
        {
            //return this.context.People.Where(x => x.Id == id).FirstOrDefault();
            return this.context.People.Find(id);
        }

        public void Create(admin person)
        {
            this.context.People.Add(person);
            this.context.SaveChanges();
        }

        public void Update(admin person)
        {
            /*Person current = this.FindById(person.Id);

            current.Name = person.Name;
            current.Surname = person.Surname;
            current.Age = person.Age;

            this.context.SaveChanges();*/

            this.context.Entry(person).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(admin person)
        {
            this.context.People.Remove(person);
            this.context.SaveChanges();
        }
    }
}