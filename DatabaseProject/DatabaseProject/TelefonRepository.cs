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

        public List<telefony> FindAll()
        {
            return this.context.Telefons.ToList();
        }
        public telefony FindById(int id)
        {
            return this.context.Telefons.Find(id);
        }
        public void Remove(telefony telefon)
        {
            this.context.Telefons.Remove(telefon);
            this.context.SaveChanges();
        }

        public void Insert(telefony telefony)
        {
            this.context.Telefons.Add(telefony);
            this.context.SaveChanges();
        }
        public void Delete(telefony telefony)
        {
            this.context.Telefons.Remove(telefony);
            this.context.SaveChanges();
        }
        public void Update(telefony telefony)
        {
            telefony db = new telefony();
            db.vyrobek = telefony.vyrobek;
            db.model = telefony.model;
            db.datumVydani = telefony.datumVydani;
            db.pamet = telefony.pamet;

            this.context.SaveChanges();

            //this.context.Entry(telefony).State = System.Data.Entity.EntityState.Modified;
        }

    }
}
