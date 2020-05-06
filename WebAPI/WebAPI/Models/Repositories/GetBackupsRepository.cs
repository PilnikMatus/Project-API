using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models.Repositories
{
    public class GetBackupsRepository
    {
        private MyContext context = new MyContext();

        public List<admin> FindAll()
        {
            return this.context.Admins.ToList();
        }

        public List<job> FindJobByIdClient(string thisClient)
        {
            return this.context.Jobs.Where(job => job.id_client == thisClient).ToList();
        }
        public backup FindBackupByIdBackup(int idBackup)
        {
            return this.context.Backups.Find(idBackup);
        }

        public void Create(admin admin)
        {
            this.context.Admins.Add(admin);
            this.context.SaveChanges();
        }

        public void Update(admin admin)
        {
            this.context.Entry(admin).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(admin admin)
        {
            this.context.Admins.Remove(admin);
            this.context.SaveChanges();
        }
    }
}