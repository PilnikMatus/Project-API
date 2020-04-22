using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class log
    {
        public int id { get; set; }
        public int id_client { get; set; }
        public string message { get; set; }
        public DateTime time { get; set; }
        public int importance { get; set; }
    }
}