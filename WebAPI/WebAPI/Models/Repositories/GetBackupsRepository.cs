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
        public fullBackupInfo FindBackupByIdBackup(int idBackup)
        {
            backup backup = new backup();
            backup = this.context.Backups.Find(idBackup);

            fullBackupInfo fbi = new fullBackupInfo(backup);
            return fbi;
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