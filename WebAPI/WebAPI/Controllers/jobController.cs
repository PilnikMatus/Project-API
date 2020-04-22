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
    public class jobController : ApiController
    {
        private jobRepository repository = new jobRepository();


        public IEnumerable<job> Get()
        {
            return this.repository.FindAll();
        }


        public job Get(int id)
        {
            return this.repository.FindById(id);
        }


        public void Post([FromBody] job value)
        {
            this.repository.Create(value);
        }



        public void Put(int id, [FromBody] job value)
        {
            value.id = id;
            this.repository.Update(value);
        }


        public void Delete(int id)
        {
            job job = this.repository.FindById(id);
            this.repository.Delete(job);
        }
    }
}
