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
    public class clientController : ApiController
    {
        private clientRepository repository = new clientRepository();

        // GET: api/client
        public IEnumerable<client> Get()
        {
            return this.repository.FindAll();
        }

        // GET: api/client/5
        public client Get(string id)
        {
            return this.repository.FindById(id);
        }

        // POST: api/client
        public void Post([FromBody]client value)
        {
            this.repository.Create(value);
        }

        // PUT: api/client/5
        public void Put(string id, [FromBody]client value)
        {
            value.id = id;
            this.repository.Update(value);
        }

        // DELETE: api/client/5
        public void Delete(string id)
        {
            client client= this.repository.FindById(id);
            this.repository.Delete(client);
        }
    }
}
