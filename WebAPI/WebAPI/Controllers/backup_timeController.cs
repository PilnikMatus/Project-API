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
    public class backup_timeController : ApiController
    {
        private backup_timeRepository repository = new backup_timeRepository();


        public IEnumerable<backup_time> Get()
        {
            return this.repository.FindAll();
        }


        public backup_time Get(int id)
        {
            return this.repository.FindById(id);
        }


        public void Post([FromBody] backup_time value)
        {
            this.repository.Create(value);
        }



        public void Put(int id, [FromBody] backup_time value)
        {
            value.id = id;
            this.repository.Update(value);
        }


        public void Delete(int id)
        {
            backup_time backup_time = this.repository.FindById(id);
            this.repository.Delete(backup_time);
        }
    }
}
