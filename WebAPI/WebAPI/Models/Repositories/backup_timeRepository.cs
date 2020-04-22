using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models.Repositories
{
    public class backup_timeRepository
    {
        private MyContext context = new MyContext();

        public List<backup_time> FindAll()
        {
            return this.context.Backup_times.ToList();
        }

        public backup_time FindById(int id)
        {
            return this.context.Backup_times.Find(id);
        }

        public void Create(backup_time backup_time)
        {
            this.context.Backup_times.Add(backup_time);
            this.context.SaveChanges();
        }

        public void Update(backup_time backup_time)
        {

            this.context.Entry(backup_time).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(backup_time backup_time)
        {
            this.context.Backup_times.Remove(backup_time);
            this.context.SaveChanges();
        }
    }
}