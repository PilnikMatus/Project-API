using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI.Models;
using WebAPI.Models.Repositories;
using System.Security.Cryptography;
namespace WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class GetBackupTargetsController : ApiController
    {
        private GetBackupTargetsRepository repository = new GetBackupTargetsRepository();


        public IEnumerable<backup_target> POST([FromBody] client client) //POST GETBACKUPS --- vrátí všechny backupy tohoto clienta
        {
            List<job> jobs = this.repository.FindJobByIdClient(client.id);
            List<backup_target> backups = new List<backup_target>();

            for (int i = 0; i < jobs.Count; i++)
            {
                backups.AddRange(this.repository.FindBackupTargetByIdBackup(jobs[i].id_backup));
            }

            return backups;  //array backupů --- časů, sources, targets
        }
    }
}
