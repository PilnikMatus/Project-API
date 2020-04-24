using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class client
    {
        public string id { get; set; }
        public string name { get; set; }
        public string mac_address { get; set; }
        public string ip_address { get; set; }
        public bool active { get; set; }
    }
}