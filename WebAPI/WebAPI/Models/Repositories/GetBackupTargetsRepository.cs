using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models.Repositories
{
    public class GetBackupTargetsRepository
    {
        private MyContext context = new MyContext();


        public List<job> FindJobByIdClient(string thisClient)
        {
            return this.context.Jobs.Where(job => job.id_client == thisClient).ToList();
        }
        public List<backup_target> FindBackupTargetByIdBackup(int idBackup)
        {
            return this.context.Backup_targets.Where(target => target.id_backup == idBackup).ToList();
        }

    }
}