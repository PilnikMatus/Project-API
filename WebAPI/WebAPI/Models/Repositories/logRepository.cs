using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models.Repositories
{
    public class logRepository
    {
        private MyContext context = new MyContext();

        public List<log> FindAll()
        {
            return this.context.Logs.ToList();
        }

        public log FindById(int id)
        {
            return this.context.Logs.Find(id);
        }

        public void Create(log log)
        {
            this.context.Logs.Add(log);
            this.context.SaveChanges();
        }

        public void Update(log log)
        {

            this.context.Entry(log).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(log log)
        {
            this.context.Logs.Remove(log);
            this.context.SaveChanges();
        }
    }
}