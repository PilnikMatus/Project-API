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
        private job_historyRepository repository = new job_historyRepository();


        public IEnumerable<job_history> Get()
        {
            return this.repository.FindAll();
        }


        public job_history Get(int id)
        {
            return this.repository.FindById(id);
        }


        public void Post([FromBody] job_history value)
        {
            this.repository.Create(value);
        }



        public void Put(int id, [FromBody] job_history value)
        {
            value.id = id;
            this.repository.Update(value);
        }


        public void Delete(int id)
        {
            job_history job_history = this.repository.FindById(id);
            this.repository.Delete(job_history);
        }
    }
}
