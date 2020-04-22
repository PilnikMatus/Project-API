using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models.Repositories
{
    public class backup_sourceRepository
    {
        private MyContext context = new MyContext();

        public List<backup_source> FindAll()
        {
            return this.context.Backup_sources.ToList();
        }

        public backup_source FindById(int id)
        {
            return this.context.Backup_sources.Find(id);
        }

        public void Create(backup_source backup_source)
        {
            this.context.Backup_sources.Add(backup_source);
            this.context.SaveChanges();
        }

        public void Update(backup_source backup_source)
        {

            this.context.Entry(backup_source).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(backup_source backup_source)
        {
            this.context.Backup_sources.Remove(backup_source);
            this.context.SaveChanges();
        }
    }
}