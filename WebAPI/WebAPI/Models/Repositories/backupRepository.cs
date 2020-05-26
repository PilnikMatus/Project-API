using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models.Repositories
{
    public class backupRepository
    {
        private MyContext context = new MyContext();


        public fullBackupAndClientsInfo FindById(int id)
        {
            backup backup = new backup();
            backup = this.context.Backups.Find(id);

            fullBackupAndClientsInfo fbi = new fullBackupAndClientsInfo(backup);

            return fbi;
        }
        public List<client> FindClientByIdBackup(int idBackup)
        {
            List<job> jobs = this.context.Jobs.Where(target => target.id_backup == idBackup).ToList();
            List<client> clients = new List<client>();
            foreach (job item in jobs)
            {
                if(this.context.Clients.Find(item.id_client) != null)
                    clients.Add(this.context.Clients.Find(item.id_client));
            }

            return clients;
        }
        public List<backup_target> FindBackupTargetByIdBackup(int idBackup)
        {
            return this.context.Backup_targets.Where(target => target.id_backup == idBackup).ToList();
        }
        public List<backup_time> FindBackupTimeByIdBackup(int idBackup)
        {
            return this.context.Backup_times.Where(time => time.id_backup == idBackup).ToList();
        }
        public List<backup_source> FindBackupSourceByIdBackup(int idBackup)
        {
            return this.context.Backup_sources.Where(source => source.id_backup == idBackup).ToList();
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