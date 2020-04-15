using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.tables;

namespace WindowsFormsApplication1
{
    public class AdminRepository
    {
        TestContext context = new TestContext();

        public List<admin> FindAll()
        {
            return this.context.Admins.ToList();
        }
    }
}
