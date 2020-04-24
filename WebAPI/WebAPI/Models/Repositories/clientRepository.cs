using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models.Repositories
{
    public class clientRepository
    {
        private MyContext context = new MyContext();

        public List<client> FindAll()
        {
            return this.context.Clients.ToList();
        }

        public client FindById(string id)
        {
            return this.context.Clients.Find(id);
        }

        public void Create(client client)
        {
            this.context.Clients.Add(client);
            this.context.SaveChanges();
        }

        public void Update(client client)
        {

            this.context.Entry(client).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(client client)
        {
            this.context.Clients.Remove(client);
            this.context.SaveChanges();
        }
    }
}