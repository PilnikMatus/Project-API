using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.tables
{
    public class admin
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public log_repetation_unit Log_repetation_unit { get; set; }
        public int log_repetation_number { get; set; }
        public int log_importance { get; set; }
    }
}
