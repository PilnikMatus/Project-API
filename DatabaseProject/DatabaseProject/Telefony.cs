using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class telefony
    {
        [Browsable(false)] //neuvidíme v datagridu
        public int id { get; set; }
        public string vyrobek { get; set; }
        public string model { get; set; }
        public int pamet { get; set; }
        public DateTime datumVydani { get; set; } = DateTime.Now;

    }
}
