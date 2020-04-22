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
    public class logController : ApiController
    {
        private logRepository repository = new logRepository();


        public IEnumerable<log> Get()
        {
            return this.repository.FindAll();
        }


        public log Get(int id)
        {
            return this.repository.FindById(id);
        }


        public void Post([FromBody] log value)
        {
            this.repository.Create(value);
        }



        public void Put(int id, [FromBody] log value)
        {
            value.id = id;
            this.repository.Update(value);
        }


        public void Delete(int id)
        {
            log log = this.repository.FindById(id);
            this.repository.Delete(log);
        }
    }
}
