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
    public class job_historyController : ApiController
    {
        private adminRepository repository = new adminRepository();


        public IEnumerable<admin> Get()
        {
            return this.repository.FindAll();
        }


        public admin Get(int id)
        {
            return this.repository.FindById(id);
        }


        public void Post([FromBody] admin value)
        {
            this.repository.Create(value);
        }



        public void Put(int id, [FromBody] admin value)
        {
            value.id = id;
            this.repository.Update(value);
        }


        public void Delete(int id)
        {
            admin admin = this.repository.FindById(id);
            this.repository.Delete(admin);
        }
    }
}
