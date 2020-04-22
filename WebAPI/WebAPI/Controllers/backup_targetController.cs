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
    public class backup_targetController : ApiController
    {
        private backup_targetRepository repository = new backup_targetRepository();


        public IEnumerable<backup_target> Get()
        {
            return this.repository.FindAll();
        }


        public backup_target Get(int id)
        {
            return this.repository.FindById(id);
        }


        public void Post([FromBody] backup_target value)
        {
            this.repository.Create(value);
        }



        public void Put(int id, [FromBody] backup_target value)
        {
            value.id = id;
            this.repository.Update(value);
        }


        public void Delete(int id)
        {
            backup_target backup_target = this.repository.FindById(id);
            this.repository.Delete(backup_target);
        }
    }
}
