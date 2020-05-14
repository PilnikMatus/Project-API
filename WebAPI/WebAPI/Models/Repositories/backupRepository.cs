using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models.Repositories
{
    public class backupRepository
    {
        private MyContext context = new MyContext();

        public List<backup> FindAll()
        {
            return this.context.Backups.ToList();
        }

        public backup FindById(int id)
        {
            return this.context.Backups.Find(id);
        }

        public void Create(backup backup)
        {
            this.context.Backups.Add(backup);
            this.context.SaveChanges();
        }

        public void Update(backup backup)
        {
            this.context.Entry(backup).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(backup backup)
        {
            this.context.Backups.Remove(backup);
            this.context.SaveChanges();
        }
    }
}