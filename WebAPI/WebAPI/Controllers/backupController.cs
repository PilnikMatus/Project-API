using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI.Models;
using WebAPI.Models.Repositories;

namespace WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class backupController : ApiController
    {
        private backupRepository repository = new backupRepository();


        public IEnumerable<backup> Get()
        {
            return this.repository.FindAll();
        }


     /*   public fullBackupInfo Get(int id, string expand = null)
        {
/////////////////////////////////////////////////////////////////////
            return this.repository.FindById(id);
        }*/

        public void Post([FromBody] backup value)
        {
            this.repository.Create(value);
        }



        public void Put(int id, [FromBody] backup value)
        {
            value.id = id;
            this.repository.Update(value);
        }


        public void Delete(int id)
        {
            backup backup = this.repository.FindById(id);
            this.repository.Delete(backup);
        }
    }
}
