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
    public class backup_sourceController : ApiController
    {
        private backup_sourceRepository repository = new backup_sourceRepository();


        public IEnumerable<backup_source> Get()
        {
            return this.repository.FindAll();
        }


        public backup_source Get(int id)
        {
            return this.repository.FindById(id);
        }


        public void Post([FromBody] backup_source value)
        {
            this.repository.Create(value);
        }



        public void Put(int id, [FromBody] backup_source value)
        {
            value.id = id;
            this.repository.Update(value);
        }


        public void Delete(int id)
        {
            backup_source backup_source = this.repository.FindById(id);
            this.repository.Delete(backup_source);
        }
    }
}
