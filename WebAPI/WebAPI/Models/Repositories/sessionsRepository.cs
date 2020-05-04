using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models.Repositories
{
    public class sessionsRepository
    {
        private MyContext context = new MyContext();

        public List<admin> FindAll()
        {
            return this.context.Admins.ToList();
        }

        public admin FindByEmail(string email)
        {
            return this.context.Admins.FirstOrDefault(admin => admin.email == email);
        }
        public admin FindByToken(string token)
        {
            return this.context.Admins.FirstOrDefault(admin => admin.token == token);
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