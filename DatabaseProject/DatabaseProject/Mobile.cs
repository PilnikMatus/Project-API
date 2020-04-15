using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Mobile
    {
        [Browsable(false)] //neuvidíme v datagridu
        public int id { get; set; }
        public string Vyrobce { get; set; }
        public string Model { get; set; }
        public int Kapacita { get; set; }
        public DateTime Datum { get; set; } = DateTime.Now;

    }
}
