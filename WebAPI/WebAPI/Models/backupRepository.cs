using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class backupRepository
    {
        private MyContext context = new MyContext();

        public List<backup> FindAll()
        {
            return this.context.backup.ToList();
        }

        public backup FindById(int id)
        {
            //return this.context.People.Where(x => x.Id == id).FirstOrDefault();
            return this.context.backup.Find(id);
        }

        public void Create(backup Backup)
        {
            this.context.backup.Add(Backup);
            this.context.SaveChanges();
        }

        public void Update(backup Backup)
        {
            /*Person current = this.FindById(person.Id);

            current.Name = person.Name;
            current.Surname = person.Surname;
            current.Age = person.Age;

            this.context.SaveChanges();*/

            this.context.Entry(Backup).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(backup Backup)
        {
            this.context.backup.Remove(Backup);
            this.context.SaveChanges();
        }
    }
}