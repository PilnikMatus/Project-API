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
    public class backupController : ApiController
    {
        private backupRepository repository = new backupRepository();


        public fullBackupAndClientsInfo Get(int id)
        {
            fullBackupAndClientsInfo backup = this.repository.FindById(id); //stáhne backup


            backup.clients = this.repository.FindClientByIdBackup(id);
            backup.backup_source = this.repository.FindBackupSourceByIdBackup(id);
            backup.backup_target = this.repository.FindBackupTargetByIdBackup(id);
            backup.backup_time = this.repository.FindBackupTimeByIdBackup(id);

            return backup;  //array backupů --- časů, sources, targets
        }

        public void POST([FromBody] fullBackupAndClientsInfo backupInfo)
        {
            //dodělat post
        }

    }
}
