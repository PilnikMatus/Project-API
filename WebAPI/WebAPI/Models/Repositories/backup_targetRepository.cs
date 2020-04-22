using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models.Repositories
{
    public class backup_targetRepository
    {
        private MyContext context = new MyContext();

        public List<backup_target> FindAll()
        {
            return this.context.Backup_targets.ToList();
        }

        public backup_target FindById(int id)
        {
            return this.context.Backup_targets.Find(id);
        }

        public void Create(backup_target backup_target)
        {
            this.context.Backup_targets.Add(backup_target);
            this.context.SaveChanges();
        }

        public void Update(backup_target backup_target)
        {

            this.context.Entry(backup_target).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(backup_target backup_target)
        {
            this.context.Backup_targets.Remove(backup_target);
            this.context.SaveChanges();
        }
    }
}