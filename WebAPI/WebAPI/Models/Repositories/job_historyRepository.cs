using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models.Repositories
{
    public class job_historyRepository
    {
        private MyContext context = new MyContext();

        public List<job_history> FindAll()
        {
            return this.context.Job_histories.ToList();
        }

        public job_history FindById(int id)
        {
            return this.context.Job_histories.Find(id);
        }

        public void Create(job_history job_history)
        {
            this.context.Job_histories.Add(job_history);
            this.context.SaveChanges();
        }

        public void Update(job_history job_history)
        {

            this.context.Entry(job_history).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(job_history job_history)
        {
            this.context.Job_histories.Remove(job_history);
            this.context.SaveChanges();
        }
    }
}