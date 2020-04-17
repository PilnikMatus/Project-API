using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class adminRepository
    {
        private MyContext context = new MyContext();

        public List<admin> FindAll()
        {
            return this.context.Admins.ToList();
        }

        public admin FindById(int id)
        {
            return this.context.Admins.Find(id);
        }

        public void Create(admin admin)
        {
            this.context.Admins.Add(admin);
            this.context.SaveChanges();
        }

        public void Update(admin admin)
        {

            this.context.Entry(admin).State = System.Data.Entity.EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(admin admin)
        {
            this.context.Admins.Remove(admin);
            this.context.SaveChanges();
        }
    }
}