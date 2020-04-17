using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class backupController : ApiController
    {
        private backupRepository repository = new backupRepository();

        // GET: api/People
        public IEnumerable<backup> Get()
        {
            return this.repository.FindAll();
        }

        // GET: api/People/5    
        public backup Get(int id)
        {
            return this.repository.FindById(id);
        }

        // POST: api/People
        public void Post([FromBody] backup value)
        {
            this.repository.Create(value);
        }


        // PUT: api/People/5
        public void Put(int id, [FromBody] backup value)
        {
            value.id = id;
            this.repository.Update(value);
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
            backup Backup = this.repository.FindById(id);
            this.repository.Delete(Backup);
        }
    }
}
