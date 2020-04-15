using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.tables;

namespace WindowsFormsApplication1
{
    public class DataModel : IListSource
    {
        public BindingList<admin> Data { get; set; } = new BindingList<admin>();

        public bool ContainsListCollection => true;

        public IList GetList()
        {
            return this.Data;
        }
    }
}
