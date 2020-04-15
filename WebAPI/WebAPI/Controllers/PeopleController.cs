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
    public class PeopleController : ApiController
    {
        private PersonRepository repository = new PersonRepository();

        // GET: api/People
        public IEnumerable<Person> Get()
        {
            return this.repository.FindAll();
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return this.repository.FindById(id);
        }

        // POST: api/People
        public void Post([FromBody]Person value)
        {
            this.repository.Create(value);
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]Person value)
        {
            value.Id = id;
            this.repository.Update(value);
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
            Person person = this.repository.FindById(id);
            this.repository.Delete(person);
        }
    }
}
