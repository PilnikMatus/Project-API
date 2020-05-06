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
    public class GetBackupsController : ApiController
    {
        private GetBackupsRepository repository = new GetBackupsRepository();


        public IEnumerable<backup> POST([FromBody] client client) //POST GETBACKUPS --- vrátí všechny backupy tohoto clienta
        {
            List<job> jobs = this.repository.FindJobByIdClient(client.id);
            List<backup> backups = new List<backup>();

            for (int i = 0; i < jobs.Count; i++)
            {
                backups.Add(this.repository.FindBackupByIdBackup(jobs[i].id_backup));
            }

            return backups;  //array backupů --- časů, sources, targets
        }
    }
}
