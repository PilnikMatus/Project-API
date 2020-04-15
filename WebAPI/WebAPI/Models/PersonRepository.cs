using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class PersonRepository
    {
        private MyContext context = new MyContext();

        public List<Person> FindAll()
        {
            return this.context.People.ToList();
        }

        public Person FindById(int id)
        {
            //return this.context.People.Where(x => x.Id == id).FirstOrDefault();
            return this.context.People.Find(id);
        }

        public void Create(Person person)
        {
            this.context.People.Add(person);
            this.context.SaveChanges();
        }

        public void Update(Person person)
        {
            /*Person current = this.FindById(person.Id);

            current.Name = person.Name;
            current.Surname = person.Surname;
            current.Age = person.Age;

            this.context.SaveChanges();*/

            this.context.Entry(person).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(Person person)
        {
            this.context.People.Remove(person);
            this.context.SaveChanges();
        }
    }
}