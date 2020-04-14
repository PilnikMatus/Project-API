using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class DataModel : IListSource
    {
        public BindingList<telefony> Data { get; set; } = new BindingList<telefony>();

        public bool ContainsListCollection => true;

        public IList GetList()
        {
            return this.Data;
        }
    }
}
