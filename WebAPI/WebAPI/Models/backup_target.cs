using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class backup_target
    {
        public int id { get; set; }
        public int id_backup { get; set; }
        public string target_type { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string server { get; set; }
        public string port { get; set; }
        public string path { get; set; }
    }
}