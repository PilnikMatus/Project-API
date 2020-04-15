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
    public class adminController : ApiController
    {
        private adminRepository repository = new adminRepository();

        // GET: api/People
        public IEnumerable<admin> Get()
        {
            return this.repository.FindAll();
        }

        // GET: api/People/5    
        public admin Get(int id)
        {
            return this.repository.FindById(id);
        }

        // POST: api/People
        public void Post([FromBody] admin value)
        {
            this.repository.Create(value);
        }


        // PUT: api/People/5
        public void Put(int id, [FromBody] admin value)
        {
            value.id = id;
            this.repository.Update(value);
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
            admin admin = this.repository.FindById(id);
            this.repository.Delete(admin);
        }
    }
}
