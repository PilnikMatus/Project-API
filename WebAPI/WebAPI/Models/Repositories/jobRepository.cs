using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models.Repositories
{
    public class jobRepository
    {
        private MyContext context = new MyContext();

        public List<job> FindAll()
        {
            return this.context.Jobs.ToList();
        }

        public job FindById(int id)
        {
            return this.context.Jobs.Find(id);
        }

        public void Create(job job)
        {
            this.context.Jobs.Add(job);
            this.context.SaveChanges();
        }

        public void Update(job job)
        {

            this.context.Entry(job).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(job job)
        {
            this.context.Jobs.Remove(job);
            this.context.SaveChanges();
        }
    }
}