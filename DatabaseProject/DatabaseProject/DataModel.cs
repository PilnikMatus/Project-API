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
        public BindingList<Mobile> Data { get; set; } = new BindingList<Mobile>();

        public bool ContainsListCollection => true;

        public IList GetList()
        {
            return this.Data;
        }
    }
}
