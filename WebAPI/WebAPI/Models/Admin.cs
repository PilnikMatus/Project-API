using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class admin
    {
        public int id { get; set; }

        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int phone { get; set; }
        public string log_repetation_unit { get; set; }
        public int log_repetation_number { get; set; }
        public int log_importance { get; set; }
    }
}