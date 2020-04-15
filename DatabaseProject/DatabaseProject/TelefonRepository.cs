using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class TelefonRepository
    {
        TestContext context = new TestContext();

        public List<Mobile> FindAll()
        {
            return this.context.Mobile.ToList();
        }
        public Mobile FindById(int id)
        {
            return this.context.Mobile.Find(id);
        }
        public void Remove(Mobile telefon)
        {
            this.context.Mobile.Remove(telefon);
            this.context.SaveChanges();
        }

        public void Insert(Mobile telefony)
        {
            this.context.Mobile.Add(telefony);
            this.context.SaveChanges();
        }
        public void Delete(Mobile telefony)
        {
            this.context.Mobile.Remove(telefony);
            this.context.SaveChanges();
        }
        public void Update(Mobile telefony)
        {
            Mobile db = new Mobile();
            db.Vyrobce = telefony.Vyrobce;
            db.Model = telefony.Model;
            db.Datum = telefony.Datum;
            db.Kapacita = telefony.Kapacita;

            this.context.SaveChanges();

            //this.context.Entry(telefony).State = System.Data.Entity.EntityState.Modified;
        }

    }
}
