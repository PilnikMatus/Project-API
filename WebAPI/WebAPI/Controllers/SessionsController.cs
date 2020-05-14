using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI.Models;
using WebAPI.Models.Repositories;
using System.Security.Cryptography;
namespace WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class sessionsController : ApiController
    {
        private sessionsRepository repository = new sessionsRepository();


        /*public IEnumerable<admin> Get() //GET SESSIONS
        {
            return this.repository.FindAll();
        }*/


 /*       public admin Get(int id) //GET SESSIONS/id
        {
            return this.repository.FindById(id);
        }*/


        public admin Post([FromBody] admin value) //POST SESSIONS 
        {
            admin admin = this.repository.FindByEmail(value.email); //GET admina podle emailu
            if (admin == null)
                return null;
            string token;
            using (MD5 md5Hash = MD5.Create())
            {
                //string hash = Randomizer.GetMd5Hash(md5Hash, source); //vytvorení hashe

                string hash = admin.password;
                if (Authorization.VerifyMd5Hash(md5Hash, value.password, hash))
                {
                    token = Authorization.CreateToken();
                }
                else
                {
                    token = null;
                    // https://stackoverflow.com/questions/10655350/returning-http-status-code-from-web-api-controller
                    //co s tim?
                    //return new HttpResponseMessage(HttpStatusCode.NotModified);
                }
            }


            admin.token = token;

            this.repository.Update(admin); //nahraní tokenu k adminovi

            return admin;
        }



        /* public void Put(int id, [FromBody] admin value) //PUT SESSIONS/id
         {
             value.id = id;
             this.repository.Update(value);
         }
         */
        public void Delete([FromBody] admin value)
        {
            admin admin = this.repository.FindByToken(value.token);
            admin.token = null;
            this.repository.Update(admin);
        }
    }
}
